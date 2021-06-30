using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SerialPortTerminal
{
    public partial class my_messages : Form
    {

        message_center mymessage_terminal = new message_center();

        public my_messages()
        {
            InitializeComponent();
            mymessage_terminal.Show();
            mymessage_terminal.Hide();
            if (!mymessage_terminal.comport.IsOpen)
            {
                mymessage_terminal.togleport();

            }
                
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void show_setting_Click(object sender, EventArgs e)
        {
            mymessage_terminal.Show();
        }

        private void read_all_Click(object sender, EventArgs e)
        {
            txt.Text = mymessage_terminal.set_text_mode();
            this.Refresh();
                        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt.Text = mymessage_terminal.get_all_msg();
            this.Refresh();
        }

        private void my_messages_Load(object sender, EventArgs e)
        {

        }

    /*    private void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // If the com port has been closed, do nothing
            if (!mymessage_terminal.comport.IsOpen) return;

            // This method will be called when there is data waiting in the port's buffer

            // Determain which mode (string or binary) the user is in
            
            {
                // Read all the data waiting in the buffer
                string data = mymessage_terminal.comport.ReadExisting();
                txt.Text = txt.Text + data;
                // Display the text to the user in the terminal
               // Log(LogMsgType.Incoming, data);
            }
           
        }*/
    }
}
