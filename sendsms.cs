/* 
 * Project:    SerialPort Terminal
 * Company:    Coad .NET, http://coad.net
 * Author:     Noah Coad, http://coad.net/noah
 * Created:    March 2005
 * 
 * Notes:      This was created to demonstrate how to use the SerialPort control for
 *             communicating with your PC's Serial RS-232 COM Port
 * 
 *             It is for educational purposes only and not sanctified for industrial use. :)
 *             Written to support the blog post article at: http://msmvps.com/blogs/coad/archive/2005/03/23/39466.aspx
 * 
 *             Search for "comport" to see how I'm using the SerialPort control.
 */

#region Namespace Inclusions
using System;
using System.Linq;
using System.Data;
using System.Text;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using SerialPortTerminal.Properties;
using System.Threading;
using System.IO;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;

#endregion

namespace SerialPortTerminal
{
  #region Public Enumerations
  //public enum DataMode1 { Text, Hex }
  //public enum LogMsgType1 { Incoming, Outgoing, Normal, Warning, Error };
  #endregion

  public partial class sendsms: Form
  { 
      public void pause (int scale)
      {
          for (int s = 0; s < 1000*scale; s++)
          {
              for (int l = 0; l < 1000*scale; l++) ;
          }

      }
      


       //byte xx = 0;
    #region Local Variables

    // The main control for communicating through the RS-232 port
    public SerialPort comport = new SerialPort();

    // Various colors for logging info
    private Color[] LogMsgTypeColor = { Color.Blue, Color.Green, Color.Black, Color.Orange, Color.Red };

    // Temp holder for whether a key was pressed
    private bool KeyHandled = false;

		private Settings settings = Settings.Default;
    #endregion

    #region Constructor
    public sendsms()
    {
			// Load user settings
			settings.Reload();

      // Build the form
      InitializeComponent();

      // Restore the users settings
      InitializeControlValues();

      // Enable/disable controls based on the current state
      EnableControls();

      // When data is recieved through the port, call this method
        comport.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
		comport.PinChanged += new SerialPinChangedEventHandler(comport_PinChanged);
    }

		void comport_PinChanged(object sender, SerialPinChangedEventArgs e)
		{
			// Show the state of the pins
			UpdatePinState();
		}

		private void UpdatePinState()
		{
			this.Invoke(new ThreadStart(() => {
				// Show the state of the pins
				chkCD.Checked = comport.CDHolding;
				chkCTS.Checked = comport.CtsHolding;
				chkDSR.Checked = comport.DsrHolding;
			}));
		}
    #endregion

    #region Local Methods
    
    /// <summary> Save the user's settings. </summary>
    private void SaveSettings()
    {
			settings.BaudRate = int.Parse(cmbBaudRate.Text);
			settings.DataBits = int.Parse(cmbDataBits.Text);
			settings.DataMode = CurrentDataMode;
			settings.Parity = (Parity)Enum.Parse(typeof(Parity), cmbParity.Text);
			settings.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cmbStopBits.Text);
			settings.PortName = cmbPortName.Text;
			settings.ClearOnOpen = chkClearOnOpen.Checked;
			settings.ClearWithDTR = chkClearWithDTR.Checked;

			settings.Save();
    }

    /// <summary> Populate the form's controls with default settings. </summary>
    private void InitializeControlValues()
    {
      cmbParity.Items.Clear(); cmbParity.Items.AddRange(Enum.GetNames(typeof(Parity)));
      cmbStopBits.Items.Clear(); cmbStopBits.Items.AddRange(Enum.GetNames(typeof(StopBits)));

			cmbParity.Text = settings.Parity.ToString();
			cmbStopBits.Text = settings.StopBits.ToString();
			cmbDataBits.Text = settings.DataBits.ToString();
			cmbParity.Text = settings.Parity.ToString();
			cmbBaudRate.Text = settings.BaudRate.ToString();
			CurrentDataMode = settings.DataMode;

			RefreshComPortList();

			chkClearOnOpen.Checked = settings.ClearOnOpen;
			chkClearWithDTR.Checked = settings.ClearWithDTR;

			// If it is still avalible, select the last com port used
			if (cmbPortName.Items.Contains(settings.PortName)) cmbPortName.Text = settings.PortName;
      else if (cmbPortName.Items.Count > 0) cmbPortName.SelectedIndex = cmbPortName.Items.Count - 1;
      else
      {
        MessageBox.Show(this, "There are no COM Ports detected on this computer.\nPlease install a COM Port and restart this app.", "No COM Ports Installed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        this.Close();
      }
    }

    /// <summary> Enable/disable controls based on the app's current state. </summary>
    private void EnableControls()
    {
      // Enable/disable controls based on whether the port is open or not
      gbPortSettings.Enabled = !comport.IsOpen;
      //txtSendData.Enabled = btnSend.Enabled = comport.IsOpen;
			//chkDTR.Enabled = chkRTS.Enabled = comport.IsOpen;

      if (comport.IsOpen) btnOpenPort.Text = "&Close Port";
      else btnOpenPort.Text = "&Open Port";
    }

    /// <summary> Send the user's data currently entered in the 'send' box.</summary>
    /// //////////////////////////////////////////////////////////////////////////////////////////////////////////
    private void SendData(byte msgno,byte msgno2)
    {
        int n1,n2;

        if (msgno > 0)
        {
            n1 = 12;
            n2 = 1;
        }
        else
        {
            n1 = 11;
            n2 = 0;
        }
      byte[] buffer2 = new byte[n1];
     //   char [] buffer3 =new char [12] ;
        buffer2[0] = 0x41;
        buffer2[1] = 0x54;
        buffer2[2] = 0x2b;
        buffer2[3] = 0x43;
        buffer2[4] = 0x4d;
        buffer2[5] = 0x47;
        buffer2[6] = 0x52;
        buffer2[7] = 0x3d;
        if (msgno > 0)
        {
            buffer2[8] = (byte)(msgno + 0x30);
        }
        else
        {
            buffer2[8] = (byte)(msgno2 + 0x30);
        }
        buffer2[9+n2] = 0x0d;
        buffer2[10+n2] = 0x0a;
        if (msgno > 0)
        {
            buffer2[9] = (byte)(msgno2 + 0x30);
        }
        //buffer2[11] = 0x04;
        //buffer2[8] = 0x32;  
      //  string buffer4 = "AT+CMGR=1";

      if (CurrentDataMode == DataMode.Text)
      {
       
        // Send the user's text straight out the port
      //   buffer2[8] =   
           
         // temp=  int.Parse(txtSendData.Text,temp );
             
             
          
      //  comport.Write(txtSendData.Text);
        //comport.Write("\r\n");
       
        // comport.Write(buffer4);
          comport.Write(buffer2,0,11 );
          for (int s=0;s<5000;s++)
          {
              for (int l = 0; l < 5000; l++) ;
          }
        //  comport.RtsEnable  = true;

/// delay pause
          /// 

          // Read all the data waiting in the buffer
          string data = comport.ReadExisting();

          // Display the text to the user in the terminal
          Log(LogMsgType.Incoming, data);

          // Show in the terminal window the user's text
      //    Log(LogMsgType.Outgoing, txtSendData.Text + data + "\n");

      }
      else
      {
        try
        {
          // Convert the user's string of hex digits (ex: B4 CA E2) to a byte array
          byte[] data = HexStringToByteArray(txtSendData.Text);

          // Send the binary data out the port
         // comport.Write(data, 0, data.Length);
          comport.Write(buffer2, 0, 11);
          // Show the hex digits on in the terminal window
          Log(LogMsgType.Outgoing, ByteArrayToHexString(buffer2 ) + "\n");
        }
        catch (FormatException)
        {
          // Inform the user if the hex string was not properly formatted
          Log(LogMsgType.Error, "Not properly formatted hex string: " + txtSendData.Text + "\n");
        }
      }
      txtSendData.SelectAll();
    }

    /// <summary> Log data to the terminal window. </summary>
    /// <param name="msgtype"> The type of message to be written. </param>
    /// <param name="msg"> The string containing the message to be shown. </param>
    private void Log(LogMsgType msgtype, string msg)
    {
      rtfTerminal.Invoke(new EventHandler(delegate
      {
        rtfTerminal.SelectedText = string.Empty;
        rtfTerminal.SelectionFont = new Font(rtfTerminal.SelectionFont, FontStyle.Bold);
        rtfTerminal.SelectionColor = LogMsgTypeColor[(int)msgtype];
        rtfTerminal.AppendText(msg);
        rtfTerminal.ScrollToCaret();
      }));
   }

    /// <summary> Convert a string of hex digits (ex: E4 CA B2) to a byte array. </summary>
    /// <param name="s"> The string containing the hex digits (with or without spaces). </param>
    /// <returns> Returns an array of bytes. </returns>
    private byte[] HexStringToByteArray(string s)
    {
      s = s.Replace(" ", "");
      byte[] buffer = new byte[s.Length / 2];
      for (int i = 0; i < s.Length; i += 2)
        buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
      return buffer;
    }

    /// <summary> Converts an array of bytes into a formatted string of hex digits (ex: E4 CA B2)</summary>
    /// <param name="data"> The array of bytes to be translated into a string of hex digits. </param>
    /// <returns> Returns a well formatted string of hex digits with spacing. </returns>
    private string ByteArrayToHexString(byte[] data)
    {
      StringBuilder sb = new StringBuilder(data.Length * 3);
      foreach (byte b in data)
        sb.Append(Convert.ToString(b, 16).PadLeft(2, '0').PadRight(3, ' '));
      return sb.ToString().ToUpper();
    }
    #endregion

    #region Local Properties
    private DataMode CurrentDataMode
    {
      get
      {
        if (rbHex.Checked) return DataMode.Hex;
        else return DataMode.Text;
      }
      set
      {
        if (value == DataMode.Text) rbText.Checked = true;
        else rbHex.Checked = true;
      }
    }
    #endregion

    

    #region Event Handlers
    private void lnkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      // Show the user the about dialog
     // (new frmAbout()).ShowDialog(this);
    }
    
    private void frmTerminal_Shown(object sender, EventArgs e)
    {
      Log(LogMsgType.Normal, String.Format("Application Started at {0}\n", DateTime.Now));
    }
    private void frmTerminal_FormClosing(object sender, FormClosingEventArgs e)
    {
      // The form is closing, save the user's preferences
      SaveSettings();
    }

    private void rbText_CheckedChanged(object sender, EventArgs e)
    { if (rbText.Checked) CurrentDataMode = DataMode.Text; }

    private void rbHex_CheckedChanged(object sender, EventArgs e)
    { if (rbHex.Checked) CurrentDataMode = DataMode.Hex; }

    private void cmbBaudRate_Validating(object sender, CancelEventArgs e)
    { int x; e.Cancel = !int.TryParse(cmbBaudRate.Text, out x); }

    private void cmbDataBits_Validating(object sender, CancelEventArgs e)
    { int x; e.Cancel = !int.TryParse(cmbDataBits.Text, out x); }

    public void btnOpenPort_Click(object sender, EventArgs e)
    {
            
			bool error = false;

      // If the port is open, close it.
      if (comport.IsOpen) comport.Close();
      else
      {
        // Set the port's settings
        comport.BaudRate = int.Parse(cmbBaudRate.Text);
        comport.DataBits = int.Parse(cmbDataBits.Text);
        comport.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cmbStopBits.Text);
        comport.Parity = (Parity)Enum.Parse(typeof(Parity), cmbParity.Text);
        comport.PortName = cmbPortName.Text;
    
				try
				{
					// Open the port
					comport.Open();
                    set_text_mode();
                    comport.DtrEnable = true;
                    comport.RtsEnable = true;
				}
				catch (UnauthorizedAccessException) { error = true; }
				catch (IOException) { error = true; }
				catch (ArgumentException) { error = true; }

				if (error) MessageBox.Show(this, "Could not open the COM port.  Most likely it is already in use, has been removed, or is unavailable.", "COM Port Unavalible", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				else
				{
					// Show the initial pin states
					UpdatePinState();
					chkDTR.Checked = comport.DtrEnable;
					chkRTS.Checked = comport.RtsEnable;
				}
      }

      // Change the state of the form's controls
      EnableControls();

      // If the port is open, send focus to the send data box
			if (comport.IsOpen)
			{
			txtSendData.Focus();
				if (chkClearOnOpen.Checked) ClearTerminal();
			}
    }
    private void btnSend_Click(object sender, EventArgs e)
    {
        for (byte i = 0; i < 10; i++)
        {
            for (byte j = 0; j < 10; j++)
                SendData(i, j);
        }
    }

    private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
        return;// If the com port has been closed, do nothing
			if (!comport.IsOpen) return;

      // This method will be called when there is data waiting in the port's buffer

      // Determain which mode (string or binary) the user is in
      if (CurrentDataMode == DataMode.Text)
      {
        // Read all the data waiting in the buffer
        string data = comport.ReadExisting();

        // Display the text to the user in the terminal
        Log(LogMsgType.Incoming, data);
      }
      else
      {
        // Obtain the number of bytes waiting in the port's buffer
        int bytes = comport.BytesToRead;

        // Create a byte array buffer to hold the incoming data
        byte[] buffer = new byte[bytes];

        // Read the data from the port and store it in our buffer
        comport.Read(buffer, 0, bytes);

        // Show the user the incoming data in hex format
        Log(LogMsgType.Incoming, ByteArrayToHexString(buffer));
      }
    }
      
    private void txtSendData_KeyDown(object sender, KeyEventArgs e)
    { 
      // If the user presses [ENTER], send the data now
      if (KeyHandled = e.KeyCode == Keys.Enter) { e.Handled = true; SendData(1,1); } 
    }
    private void txtSendData_KeyPress(object sender, KeyPressEventArgs e)
    { e.Handled = KeyHandled; }
    #endregion

		private void chkDTR_CheckedChanged(object sender, EventArgs e)
		{
			comport.DtrEnable = chkDTR.Checked;
			if (chkDTR.Checked && chkClearWithDTR.Checked) ClearTerminal();
		}

		private void chkRTS_CheckedChanged(object sender, EventArgs e)
		{
			comport.RtsEnable = chkRTS.Checked;
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			ClearTerminal();
		}

		private void ClearTerminal()
		{
			rtfTerminal.Clear();
		}

		private void tmrCheckComPorts_Tick(object sender, EventArgs e)
		{
			// checks to see if COM ports have been added or removed
			// since it is quite common now with USB-to-Serial adapters
			RefreshComPortList();
		}

		private void RefreshComPortList()
		{
			// Determain if the list of com port names has changed since last checked
			string selected = RefreshComPortList(cmbPortName.Items.Cast<string>(), cmbPortName.SelectedItem as string, comport.IsOpen);

			// If there was an update, then update the control showing the user the list of port names
			if (!String.IsNullOrEmpty(selected))
			{
				cmbPortName.Items.Clear();
				cmbPortName.Items.AddRange(OrderedPortNames());
				cmbPortName.SelectedItem = selected;
			}
		}

		private string[] OrderedPortNames()
		{
			// Just a placeholder for a successful parsing of a string to an integer
			int num;

			// Order the serial port names in numberic order (if possible)
			return SerialPort.GetPortNames().OrderBy(a => a.Length > 3 && int.TryParse(a.Substring(3), out num) ? num : 0).ToArray(); 
		}
		
		private string RefreshComPortList(IEnumerable<string> PreviousPortNames, string CurrentSelection, bool PortOpen)
		{
			// Create a new return report to populate
			string selected = null;

			// Retrieve the list of ports currently mounted by the operating system (sorted by name)
			string[] ports = SerialPort.GetPortNames();

			// First determain if there was a change (any additions or removals)
			bool updated = PreviousPortNames.Except(ports).Count() > 0 || ports.Except(PreviousPortNames).Count() > 0;

			// If there was a change, then select an appropriate default port
			if (updated)
			{
				// Use the correctly ordered set of port names
				ports = OrderedPortNames();

				// Find newest port if one or more were added
				string newest = SerialPort.GetPortNames().Except(PreviousPortNames).OrderBy(a => a).LastOrDefault();

				// If the port was already open... (see logic notes and reasoning in Notes.txt)
				if (PortOpen)
				{
					if (ports.Contains(CurrentSelection)) selected = CurrentSelection;
					else if (!String.IsNullOrEmpty(newest)) selected = newest;
					else selected = ports.LastOrDefault();
				}
				else
				{
					if (!String.IsNullOrEmpty(newest)) selected = newest;
					else if (ports.Contains(CurrentSelection)) selected = CurrentSelection;
					else selected = ports.LastOrDefault();
				}
			}

			// If there was a change to the port list, return the recommended default selection
			return selected;
		}

        private void txtSendData_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbPortName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbDataBits_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rtfTerminal_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbStopBits_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gbPortSettings_Enter(object sender, EventArgs e)
        {

        }

        private void frmTerminal_Load(object sender, EventArgs e)
        {
            togleport();
            comport.DtrEnable = true;
            comport.RtsEnable = true;
        }

        private void done_Click(object sender, EventArgs e)
        {
            comport.Close();
            this.Hide();
            
        }
	
  /////////////////////////////////////////////////////////////////////////////////////////////////////
        public string get_all_msg()
        {
            
            
            byte[] buffer2 = new byte[20];
            //   char [] buffer3 =new char [12] ;  AT+CMGL="ALL" = 41542b434d47 4c3d22414c4c22
            buffer2[0] = 0x41;//                                   41542b434d474c3d22414c4c22
            buffer2[1] = 0x54;
            buffer2[2] = 0x2b;
            buffer2[3] = 0x43;
            buffer2[4] = 0x4d;
            buffer2[5] = 0x47;
            buffer2[6] = 0x4c;
            buffer2[7] = 0x3d;
            buffer2[8] = 0x22;
            buffer2[9] = 0x41;
            buffer2[10] = 0x4c;
            buffer2[11] = 0x4c;
            buffer2[12] = 0x22;
            buffer2[13] = 0x0d;
            buffer2[14] = 0x0a;

       
           
                comport.Write(buffer2, 0, 15);
                

                /// delay pause
               for (int i = 0; i < 60000; i++) ;

                // Read all the data waiting in the buffer
                string data = comport.ReadExisting();

                // Display the text to the user in the terminal
                  Log(LogMsgType.Incoming, data);

                // Show in the terminal window the user's text
                Log(LogMsgType.Outgoing, txtSendData.Text + data + "\n");

                return data;
             
        }
////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void togleport()
        {
            bool error = false;

            // If the port is open, close it.
            if (comport.IsOpen) comport.Close();
            else
            {
                // Set the port's settings
                comport.BaudRate = int.Parse(cmbBaudRate.Text);
                comport.DataBits = int.Parse(cmbDataBits.Text);
                comport.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cmbStopBits.Text);
                comport.Parity = (Parity)Enum.Parse(typeof(Parity), cmbParity.Text);
                comport.PortName = cmbPortName.Text;

                try
                {
                    // Open the port
                    comport.Open();
                    comport.DtrEnable = true;
                    comport.RtsEnable = true;
                }
                catch (UnauthorizedAccessException) { error = true; }
                catch (IOException) { error = true; }
                catch (ArgumentException) { error = true; }

                if (error) MessageBox.Show(this, "Could not open the COM port.  Most likely it is already in use, has been removed, or is unavailable.", "COM Port Unavalible", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {
                    // Show the initial pin states
                    UpdatePinState();
                    chkDTR.Checked = comport.DtrEnable;
                    chkRTS.Checked = comport.RtsEnable;
                }
            }

            // Change the state of the form's controls
            EnableControls();

            // If the port is open, send focus to the send data box
            if (comport.IsOpen)
            {
                txtSendData.Focus();
                if (chkClearOnOpen.Checked) ClearTerminal();
            }
        }
//////////////////////////////////////////////////////////////////////////////////////////////////////////

        public string set_text_mode()
        {

            byte[] buffer2 = new byte[20];
            //   char [] buffer3 =new char [12] ;  AT+CMGF=1 = 41542b434d47 463d31
            buffer2[0] = 0x41;
            buffer2[1] = 0x54;
            buffer2[2] = 0x2b;
            buffer2[3] = 0x43;
            buffer2[4] = 0x4d;
            buffer2[5] = 0x47;
            buffer2[6] = 0x46;
            buffer2[7] = 0x3d;
            buffer2[8] = 0x31;
           //buffer2[9] = 0x4c;
           // buffer2[10] = 0x4c;
           // buffer2[11] = 0x22;
            buffer2[9] = 0x0d;
            buffer2[10] = 0x0a;



            comport.Write(buffer2, 0, 11);


            /// delay pause
            for (int i = 0; i < 60000; i++) ;

            // Read all the data waiting in the buffer
            string dat = comport.ReadExisting();

            // Display the text to the user in the terminal
               Log(LogMsgType.Incoming, dat);

            // Show in the terminal window the user's text
            // Log(LogMsgType.Outgoing, txtSendData.Text + data + "\n");

            return dat;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            set_text_mode();
        }
  ///////////////////////////////////////////////////////////////////////////////////////////////////////
        private void send_data_phone(string phone,string content_text)
        {       
                string data="mmm";

              

                if (CurrentDataMode == DataMode.Text)
                {
                    // Send the user's text straight out the port
                    //   buffer2[8] =   
                    // temp=  int.Parse(txtSendData.Text,temp );
                    Log(LogMsgType.Outgoing, "---------------------------------------------------------------"+ "\n");
                    string dat = "AT+CMGW=" + '"'+ '+' + phone + '"'  + "\r\n";
                    byte[] buffer4 = System.Text.Encoding.ASCII.GetBytes(dat);
                    int text_length = dat.Length;
                    comport.Write(buffer4, 0, text_length);
                    pause(15);
                    Log(LogMsgType.Outgoing, "---send mobile phone="+phone + "\n");
                    byte[] cz = new byte[2];
                    cz[0]=  0x1A;
                    dat = content_text  ;

                    buffer4 = System.Text.Encoding.ASCII.GetBytes(dat);
                    text_length = dat.Length;
                    comport.Write(buffer4, 0, text_length);
                    comport.Write(cz,0,1);
                    comport.Write("\r\n");
                    pause(15);
                    Log(LogMsgType.Outgoing, "---send text=" + content_text + "\n");

                   

                    //  comport.RtsEnable  = true;
                    /// delay pause
                    ///         
                   // Read all the data waiting in the buffer
                     data = comport.ReadExisting();       
                     // Display the text to the user in the terminal
                       // Log(LogMsgType.Incoming, data);
                    //rtfTerminal.Text  
                    // Show in the terminal window the user's text
                    Log(LogMsgType.Outgoing, "----mobile response=" +data + "\n");

                    int firstChar = data.IndexOf("+CMGW:");

                    string newdata=data.Substring(firstChar+6);
                    firstChar = newdata.IndexOf("\r\n");
                    newdata = newdata.Substring(0, firstChar);

                    //AT+CMSS=1
                    dat = "AT+CMSS=" + newdata + "\r\n";
                     buffer4 = System.Text.Encoding.ASCII.GetBytes(dat);
                     text_length = dat.Length;
                    comport.Write(buffer4, 0, text_length);
                    pause(15);
                    data = comport.ReadExisting();
                    Log(LogMsgType.Outgoing, "----mobile response=" + data + "\n");


                }
                else
                {
                    try
                    {
                        // Convert the user's string of hex digits (ex: B4 CA E2) to a byte array
                        //byte[] data = HexStringToByteArray(txtSendData.Text);

                        // Send the binary data out the port
                        // comport.Write(data, 0, data.Length);
                        //comport.Write(buffer2, 0, 11);
                        // Show the hex digits on in the terminal window
                       // Log(LogMsgType.Outgoing, ByteArrayToHexString(data) + "\n");
                    }
                    catch (FormatException)
                    {
                        // Inform the user if the hex string was not properly formatted
                        Log(LogMsgType.Error, "Not properly formatted hex string: " + txtSendData.Text + "\n");
                    }
                }
                txtSendData.SelectAll();
                
            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void see_mess_Click(object sender, EventArgs e)
            {
           
            }

            private void next_Click(object sender, EventArgs e)
            {
         
            }

            private void pervious_Click(object sender, EventArgs e)
            {
           
            }

       

            private void send_Click(object sender, EventArgs e)
            {

            }

        

            private void select_db_Click(object sender, EventArgs e)
            {

                enter_no.Checked = false;
                select_db.Checked = true;
                number_sms.Enabled = false;
                year_text.Enabled = true;
                spc_text.Enabled = true;
                

            
            }

            private void enter_no_Click(object sender, EventArgs e)
            {
                select_db.Checked = false;
                 enter_no.Checked = true;
                 number_sms.Enabled = true;
                 year_text.Enabled = false;
                 spc_text.Enabled = false;
                
            }

            private void textBox4_TextChanged(object sender, EventArgs e)
            {

            }

            private void send_text_Click(object sender, EventArgs e)
            {
                               
                /////////////////////////////////////// // odbc connection db2
                OdbcConnection conn = new OdbcConnection();
                conn.ConnectionString =
                              "Dsn=db2;" +
                              "Uid=db2admin;" +
                              "Pwd=db2admin;";
                conn.Open();

                if (select_db.Checked == true)
                {
                    if (year_text.Text == "" && spc_text.Text == "")
                    {
                        using (OdbcCommand com = new OdbcCommand(

                        "SELECT phone FROM MOHAMED.student ", conn))
                        {
                            //com.Parameters.AddWithValue("@var", paramWord);

                            using (OdbcDataReader reader = com.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string t_phone = reader.GetString(0);
                                    send_data_phone(t_phone, message_text.Text);
                                    // Word is from the database. Do something with it.

                                }
                            }
                        }


                    }
                    else if (year_text.Text != "" && spc_text.Text != "")
                    {
                        int y_student = int.Parse(year_text.Text);
                        int s_student = int.Parse(spc_text.Text);
                        string str_select;
                        str_select = string.Format("SELECT phone FROM MOHAMED.student  where year = {0} and  specialization = {1}", y_student, s_student);


                        using (OdbcCommand com = new OdbcCommand(str_select, conn))
                        {
                            //com.Parameters.AddWithValue("@var", paramWord);

                            using (OdbcDataReader reader = com.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string t_phone = reader.GetString(0);
                                    send_data_phone(t_phone, message_text.Text);
                                    // Word is from the database. Do something with it.

                                }
                            }


                        }
                    }
                    else if (year_text.Text == "" && spc_text.Text != "")
                    {
                        //int y_student = int.Parse(year_text.Text);
                        int s_student = int.Parse(spc_text.Text);
                        string str_select;
                        str_select = string.Format("SELECT phone FROM MOHAMED.student  where    specialization = {0}", s_student);


                        using (OdbcCommand com = new OdbcCommand(str_select, conn))
                        {
                            //com.Parameters.AddWithValue("@var", paramWord);

                            using (OdbcDataReader reader = com.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string t_phone = reader.GetString(0);
                                             send_data_phone(t_phone, message_text.Text);
                                    // Word is from the database. Do something with it.

                                }
                            }


                        }


                    }
                    else
                    {
                        int y_student = int.Parse(year_text.Text);
                        //int s_student = int.Parse(spc_text.Text);
                        string str_select;
                        str_select = string.Format("SELECT phone FROM MOHAMED.student  where    year= {0}", y_student);


                        using (OdbcCommand com = new OdbcCommand(str_select, conn))
                        {
                            //com.Parameters.AddWithValue("@var", paramWord);

                            using (OdbcDataReader reader = com.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string t_phone = reader.GetString(0);
                                         send_data_phone(t_phone, message_text.Text);
                                    // Word is from the database. Do something with it.

                                }
                            }

                        }

                    }

                }




                else if (enter_no.Checked == true)
                {
                    string phone_1 = "2" + number_sms.Text;

                    send_data_phone(phone_1, message_text.Text);
                }

        }

            private void message_text_TextChanged(object sender, EventArgs e)
            {

            }

        
  //////////////////////////////////////////////////////////////////////////////////////////////////


      public string cutting_data(string data)
        {
            int firstChar1 = data.IndexOf("+CMGR:");        // check for postion of  +cmgr which uasually is response of modem after sending AT+cmgr
            if (firstChar1 > -1)
            {
                data = data.Substring(firstChar1 + 6);      //removing the part "+cmgr"
                string type = data.Substring(0, data.IndexOf(','));//  after removing first part  next part is type of message  read or unread or unsent 
                data = data.Substring(data.IndexOf(',') + 1);// removing secound part 
                if (type.IndexOf("REC READ") >= 0)           // in case of read message 
                {

                    data = data.Substring(data.IndexOf('"') + 2); //removing an wanted parts
                    int cot_pos = data.IndexOf('"');                //length of next part (phone)
                    string phone_no = data.Substring(0, cot_pos);   // saving phone no in vairable 
                    data = data.Substring(data.IndexOf(',') + 1);
                    data = data.Substring(data.IndexOf(',') + 2);   //take  untill cotations
                    string date_st = data.Substring(0, data.IndexOf(',')); // next part is date of message 
                    data = data.Substring(data.IndexOf(',') + 1);
                    string time_st = data.Substring(0, data.IndexOf('"'));//time
                    data = data.Substring(data.IndexOf('"') + 1);

                    data = data.Substring(data.IndexOf("+"));
                    string provider_phone = data.Substring(0, data.IndexOf(','));   //provider number 
                    data = data.Substring(data.IndexOf("\r\n") + 2);
                    // message text 
                    string msg_txt1 = data.Substring(0, data.IndexOf("\r\n"));
                    string msg_txt = data.Substring(0, data.IndexOf(","));

                    string all_data = "TYPE"+type+"   phone:" + phone_no + "     " + "date:" + date_st + "   " + "time:" + time_st + "   " + "text:" + msg_txt;
                    return all_data;
                }
                else if (type.IndexOf("REC UNREAD") >= 0)                   // in case of unread
                {

                    data = data.Substring(data.IndexOf('"') + 2);
                    int cot_pos = data.IndexOf('"');
                    string phone_no = data.Substring(0, cot_pos);
                    data = data.Substring(data.IndexOf(',') + 1);
                    data = data.Substring(data.IndexOf(',') + 2); //take  untill cotations
                    string date_st = data.Substring(0, data.IndexOf(','));
                    data = data.Substring(data.IndexOf(',') + 1);
                    string time_st = data.Substring(0, data.IndexOf('"'));
                    data = data.Substring(data.IndexOf('"') + 1);
                    data = data.Substring(data.IndexOf("+"));
                    string provider_phone = data.Substring(0, data.IndexOf(','));
                    data = data.Substring(data.IndexOf("\r\n") + 2);
                    string msg_txt1 = data.Substring(0, data.IndexOf("\r\n"));
                    string msg_txt = data.Substring(0, data.IndexOf(","));
                    string all_data = "TYPE" + type + "   phone:" + phone_no + "     " + "date:" + date_st + "   " + "time:" + time_st + "   " + "text:" + msg_txt;
                    return all_data;
                    
                }
                else if (type.IndexOf("STO UNSENT") >= 0)
                {
                    data = data.Substring(data.IndexOf('"') + 2);
                    int cot_pos = data.IndexOf('"');
                    string phone_no = data.Substring(0, cot_pos);
                    data = data.Substring(data.IndexOf(',') + 1);
                    data = data.Substring(data.IndexOf('+')); //take  untill cotations

                    string provider_phone_st = data.Substring(0, data.IndexOf('"'));
                    data = data.Substring(data.IndexOf("\n") + 1);
                    string msg_txt1 = data.Substring(0, data.IndexOf("\r\n"));
                    string msg_txt = data.Substring(0, data.IndexOf(","));
                    string all_data = "TYPE" + type + "  phone:" + phone_no + "     " + "date:" + "   " + "text:" + msg_txt;
                    return all_data;

                      }
            }
            else if (firstChar1 < 0)
            {
                //in case  doesnt found message in this number +CMS ERROR: 321
                firstChar1 = data.IndexOf("+CMS");
                data = data.Substring(firstChar1 + 4);
                string type_error = data.Substring(0, data.IndexOf('1') + 1);
                return  "NO message////////////" ;

            } return " none";

        } 
  







      //////////////////////////////////////////////////////////////////////////////////////////////
  }

}