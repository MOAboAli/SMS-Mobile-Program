namespace SerialPortTerminal
{
  partial class center
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(center));
        this.rtfTerminal = new System.Windows.Forms.RichTextBox();
        this.txtSendData = new System.Windows.Forms.TextBox();
        this.lblSend = new System.Windows.Forms.Label();
        this.btnSend = new System.Windows.Forms.Button();
        this.cmbPortName = new System.Windows.Forms.ComboBox();
        this.cmbBaudRate = new System.Windows.Forms.ComboBox();
        this.rbHex = new System.Windows.Forms.RadioButton();
        this.rbText = new System.Windows.Forms.RadioButton();
        this.gbMode = new System.Windows.Forms.GroupBox();
        this.lblComPort = new System.Windows.Forms.Label();
        this.lblBaudRate = new System.Windows.Forms.Label();
        this.label1 = new System.Windows.Forms.Label();
        this.cmbParity = new System.Windows.Forms.ComboBox();
        this.lblDataBits = new System.Windows.Forms.Label();
        this.cmbDataBits = new System.Windows.Forms.ComboBox();
        this.lblStopBits = new System.Windows.Forms.Label();
        this.cmbStopBits = new System.Windows.Forms.ComboBox();
        this.btnOpenPort = new System.Windows.Forms.Button();
        this.gbPortSettings = new System.Windows.Forms.GroupBox();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.chkRTS = new System.Windows.Forms.CheckBox();
        this.chkCD = new System.Windows.Forms.CheckBox();
        this.chkDSR = new System.Windows.Forms.CheckBox();
        this.chkCTS = new System.Windows.Forms.CheckBox();
        this.chkDTR = new System.Windows.Forms.CheckBox();
        this.btnClear = new System.Windows.Forms.Button();
        this.chkClearOnOpen = new System.Windows.Forms.CheckBox();
        this.chkClearWithDTR = new System.Windows.Forms.CheckBox();
        this.done = new System.Windows.Forms.Button();
        this.see_mess = new System.Windows.Forms.Button();
        this.no_message = new System.Windows.Forms.TextBox();
        this.next = new System.Windows.Forms.Button();
        this.pervious = new System.Windows.Forms.Button();
        this.delete = new System.Windows.Forms.Button();
        this.rec_read_sent_stored = new System.Windows.Forms.RadioButton();
        this.rec_read_sent = new System.Windows.Forms.RadioButton();
        this.all = new System.Windows.Forms.RadioButton();
        this.all_rec_read = new System.Windows.Forms.RadioButton();
        this.del_msg_nubmer = new System.Windows.Forms.RadioButton();
        this.msg_nubmer = new System.Windows.Forms.TextBox();
        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.gbMode.SuspendLayout();
        this.gbPortSettings.SuspendLayout();
        this.groupBox1.SuspendLayout();
        this.groupBox2.SuspendLayout();
        this.SuspendLayout();
        // 
        // rtfTerminal
        // 
        this.rtfTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.rtfTerminal.Location = new System.Drawing.Point(12, 12);
        this.rtfTerminal.Name = "rtfTerminal";
        this.rtfTerminal.Size = new System.Drawing.Size(414, 295);
        this.rtfTerminal.TabIndex = 0;
        this.rtfTerminal.Text = "";
        this.rtfTerminal.TextChanged += new System.EventHandler(this.rtfTerminal_TextChanged);
        // 
        // txtSendData
        // 
        this.txtSendData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.txtSendData.Location = new System.Drawing.Point(23, 24);
        this.txtSendData.Name = "txtSendData";
        this.txtSendData.Size = new System.Drawing.Size(45, 20);
        this.txtSendData.TabIndex = 2;
        this.txtSendData.Visible = false;
        this.txtSendData.TextChanged += new System.EventHandler(this.txtSendData_TextChanged);
        this.txtSendData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSendData_KeyDown);
        this.txtSendData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSendData_KeyPress);
        // 
        // lblSend
        // 
        this.lblSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.lblSend.AutoSize = true;
        this.lblSend.Location = new System.Drawing.Point(9, 379);
        this.lblSend.Name = "lblSend";
        this.lblSend.Size = new System.Drawing.Size(61, 13);
        this.lblSend.TabIndex = 1;
        this.lblSend.Text = "Send &Data:";
        this.lblSend.Visible = false;
        // 
        // btnSend
        // 
        this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnSend.Location = new System.Drawing.Point(358, 313);
        this.btnSend.Name = "btnSend";
        this.btnSend.Size = new System.Drawing.Size(72, 27);
        this.btnSend.TabIndex = 3;
        this.btnSend.Text = "see all";
        this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
        // 
        // cmbPortName
        // 
        this.cmbPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbPortName.FormattingEnabled = true;
        this.cmbPortName.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6"});
        this.cmbPortName.Location = new System.Drawing.Point(13, 35);
        this.cmbPortName.Name = "cmbPortName";
        this.cmbPortName.Size = new System.Drawing.Size(67, 21);
        this.cmbPortName.TabIndex = 1;
        this.cmbPortName.SelectedIndexChanged += new System.EventHandler(this.cmbPortName_SelectedIndexChanged);
        // 
        // cmbBaudRate
        // 
        this.cmbBaudRate.FormattingEnabled = true;
        this.cmbBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
        this.cmbBaudRate.Location = new System.Drawing.Point(86, 35);
        this.cmbBaudRate.Name = "cmbBaudRate";
        this.cmbBaudRate.Size = new System.Drawing.Size(69, 21);
        this.cmbBaudRate.TabIndex = 3;
        this.cmbBaudRate.Validating += new System.ComponentModel.CancelEventHandler(this.cmbBaudRate_Validating);
        this.cmbBaudRate.SelectedIndexChanged += new System.EventHandler(this.cmbBaudRate_SelectedIndexChanged);
        // 
        // rbHex
        // 
        this.rbHex.AutoSize = true;
        this.rbHex.Location = new System.Drawing.Point(12, 39);
        this.rbHex.Name = "rbHex";
        this.rbHex.Size = new System.Drawing.Size(44, 17);
        this.rbHex.TabIndex = 1;
        this.rbHex.Text = "Hex";
        this.rbHex.CheckedChanged += new System.EventHandler(this.rbHex_CheckedChanged);
        // 
        // rbText
        // 
        this.rbText.AutoSize = true;
        this.rbText.Location = new System.Drawing.Point(16, 16);
        this.rbText.Name = "rbText";
        this.rbText.Size = new System.Drawing.Size(46, 17);
        this.rbText.TabIndex = 0;
        this.rbText.Text = "Text";
        this.rbText.CheckedChanged += new System.EventHandler(this.rbText_CheckedChanged);
        // 
        // gbMode
        // 
        this.gbMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.gbMode.Controls.Add(this.rbText);
        this.gbMode.Controls.Add(this.rbHex);
        this.gbMode.Location = new System.Drawing.Point(21, 385);
        this.gbMode.Name = "gbMode";
        this.gbMode.Size = new System.Drawing.Size(105, 64);
        this.gbMode.TabIndex = 5;
        this.gbMode.TabStop = false;
        this.gbMode.Text = "Data &Mode";
        this.gbMode.Visible = false;
        // 
        // lblComPort
        // 
        this.lblComPort.AutoSize = true;
        this.lblComPort.Location = new System.Drawing.Point(12, 19);
        this.lblComPort.Name = "lblComPort";
        this.lblComPort.Size = new System.Drawing.Size(56, 13);
        this.lblComPort.TabIndex = 0;
        this.lblComPort.Text = "COM Port:";
        // 
        // lblBaudRate
        // 
        this.lblBaudRate.AutoSize = true;
        this.lblBaudRate.Location = new System.Drawing.Point(85, 19);
        this.lblBaudRate.Name = "lblBaudRate";
        this.lblBaudRate.Size = new System.Drawing.Size(61, 13);
        this.lblBaudRate.TabIndex = 2;
        this.lblBaudRate.Text = "Baud Rate:";
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(163, 19);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(36, 13);
        this.label1.TabIndex = 4;
        this.label1.Text = "Parity:";
        // 
        // cmbParity
        // 
        this.cmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbParity.FormattingEnabled = true;
        this.cmbParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
        this.cmbParity.Location = new System.Drawing.Point(161, 35);
        this.cmbParity.Name = "cmbParity";
        this.cmbParity.Size = new System.Drawing.Size(60, 21);
        this.cmbParity.TabIndex = 5;
        // 
        // lblDataBits
        // 
        this.lblDataBits.AutoSize = true;
        this.lblDataBits.Location = new System.Drawing.Point(229, 19);
        this.lblDataBits.Name = "lblDataBits";
        this.lblDataBits.Size = new System.Drawing.Size(53, 13);
        this.lblDataBits.TabIndex = 6;
        this.lblDataBits.Text = "Data Bits:";
        // 
        // cmbDataBits
        // 
        this.cmbDataBits.FormattingEnabled = true;
        this.cmbDataBits.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
        this.cmbDataBits.Location = new System.Drawing.Point(227, 35);
        this.cmbDataBits.Name = "cmbDataBits";
        this.cmbDataBits.Size = new System.Drawing.Size(60, 21);
        this.cmbDataBits.TabIndex = 7;
        this.cmbDataBits.Validating += new System.ComponentModel.CancelEventHandler(this.cmbDataBits_Validating);
        this.cmbDataBits.SelectedIndexChanged += new System.EventHandler(this.cmbDataBits_SelectedIndexChanged);
        // 
        // lblStopBits
        // 
        this.lblStopBits.AutoSize = true;
        this.lblStopBits.Location = new System.Drawing.Point(295, 19);
        this.lblStopBits.Name = "lblStopBits";
        this.lblStopBits.Size = new System.Drawing.Size(52, 13);
        this.lblStopBits.TabIndex = 8;
        this.lblStopBits.Text = "Stop Bits:";
        // 
        // cmbStopBits
        // 
        this.cmbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbStopBits.FormattingEnabled = true;
        this.cmbStopBits.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
        this.cmbStopBits.Location = new System.Drawing.Point(293, 35);
        this.cmbStopBits.Name = "cmbStopBits";
        this.cmbStopBits.Size = new System.Drawing.Size(65, 21);
        this.cmbStopBits.TabIndex = 9;
        this.cmbStopBits.SelectedIndexChanged += new System.EventHandler(this.cmbStopBits_SelectedIndexChanged);
        // 
        // btnOpenPort
        // 
        this.btnOpenPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnOpenPort.Location = new System.Drawing.Point(619, 370);
        this.btnOpenPort.Name = "btnOpenPort";
        this.btnOpenPort.Size = new System.Drawing.Size(97, 39);
        this.btnOpenPort.TabIndex = 6;
        this.btnOpenPort.Text = "&Open Port";
        this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
        // 
        // gbPortSettings
        // 
        this.gbPortSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.gbPortSettings.Controls.Add(this.cmbPortName);
        this.gbPortSettings.Controls.Add(this.cmbBaudRate);
        this.gbPortSettings.Controls.Add(this.cmbStopBits);
        this.gbPortSettings.Controls.Add(this.cmbParity);
        this.gbPortSettings.Controls.Add(this.cmbDataBits);
        this.gbPortSettings.Controls.Add(this.lblComPort);
        this.gbPortSettings.Controls.Add(this.lblStopBits);
        this.gbPortSettings.Controls.Add(this.lblBaudRate);
        this.gbPortSettings.Controls.Add(this.lblDataBits);
        this.gbPortSettings.Controls.Add(this.label1);
        this.gbPortSettings.Location = new System.Drawing.Point(2, 379);
        this.gbPortSettings.Name = "gbPortSettings";
        this.gbPortSettings.Size = new System.Drawing.Size(389, 64);
        this.gbPortSettings.TabIndex = 4;
        this.gbPortSettings.TabStop = false;
        this.gbPortSettings.Text = "COM Serial Port Settings";
        this.gbPortSettings.Visible = false;
        this.gbPortSettings.Enter += new System.EventHandler(this.gbPortSettings_Enter);
        // 
        // groupBox1
        // 
        this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.groupBox1.Controls.Add(this.chkRTS);
        this.groupBox1.Controls.Add(this.chkCD);
        this.groupBox1.Controls.Add(this.chkDSR);
        this.groupBox1.Controls.Add(this.chkCTS);
        this.groupBox1.Controls.Add(this.chkDTR);
        this.groupBox1.Controls.Add(this.txtSendData);
        this.groupBox1.Controls.Add(this.chkClearWithDTR);
        this.groupBox1.Controls.Add(this.chkClearOnOpen);
        this.groupBox1.Location = new System.Drawing.Point(2, 395);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(270, 48);
        this.groupBox1.TabIndex = 7;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "&Line Signals";
        this.groupBox1.Visible = false;
        // 
        // chkRTS
        // 
        this.chkRTS.AutoSize = true;
        this.chkRTS.Location = new System.Drawing.Point(65, 20);
        this.chkRTS.Name = "chkRTS";
        this.chkRTS.Size = new System.Drawing.Size(48, 17);
        this.chkRTS.TabIndex = 1;
        this.chkRTS.Text = "RTS";
        this.chkRTS.UseVisualStyleBackColor = true;
        this.chkRTS.CheckedChanged += new System.EventHandler(this.chkRTS_CheckedChanged);
        // 
        // chkCD
        // 
        this.chkCD.AutoSize = true;
        this.chkCD.Enabled = false;
        this.chkCD.Location = new System.Drawing.Point(226, 20);
        this.chkCD.Name = "chkCD";
        this.chkCD.Size = new System.Drawing.Size(41, 17);
        this.chkCD.TabIndex = 4;
        this.chkCD.Text = "CD";
        this.chkCD.UseVisualStyleBackColor = true;
        // 
        // chkDSR
        // 
        this.chkDSR.AutoSize = true;
        this.chkDSR.Enabled = false;
        this.chkDSR.Location = new System.Drawing.Point(172, 20);
        this.chkDSR.Name = "chkDSR";
        this.chkDSR.Size = new System.Drawing.Size(49, 17);
        this.chkDSR.TabIndex = 3;
        this.chkDSR.Text = "DSR";
        this.chkDSR.UseVisualStyleBackColor = true;
        // 
        // chkCTS
        // 
        this.chkCTS.AutoSize = true;
        this.chkCTS.Enabled = false;
        this.chkCTS.Location = new System.Drawing.Point(119, 20);
        this.chkCTS.Name = "chkCTS";
        this.chkCTS.Size = new System.Drawing.Size(47, 17);
        this.chkCTS.TabIndex = 2;
        this.chkCTS.Text = "CTS";
        this.chkCTS.UseVisualStyleBackColor = true;
        // 
        // chkDTR
        // 
        this.chkDTR.AutoSize = true;
        this.chkDTR.Location = new System.Drawing.Point(10, 20);
        this.chkDTR.Name = "chkDTR";
        this.chkDTR.Size = new System.Drawing.Size(49, 17);
        this.chkDTR.TabIndex = 0;
        this.chkDTR.Text = "DTR";
        this.chkDTR.UseVisualStyleBackColor = true;
        this.chkDTR.CheckedChanged += new System.EventHandler(this.chkDTR_CheckedChanged);
        // 
        // btnClear
        // 
        this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnClear.Location = new System.Drawing.Point(432, 12);
        this.btnClear.Name = "btnClear";
        this.btnClear.Size = new System.Drawing.Size(75, 36);
        this.btnClear.TabIndex = 9;
        this.btnClear.Text = "&Clear";
        this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
        // 
        // chkClearOnOpen
        // 
        this.chkClearOnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.chkClearOnOpen.AutoSize = true;
        this.chkClearOnOpen.Location = new System.Drawing.Point(95, -3);
        this.chkClearOnOpen.Name = "chkClearOnOpen";
        this.chkClearOnOpen.Size = new System.Drawing.Size(94, 17);
        this.chkClearOnOpen.TabIndex = 10;
        this.chkClearOnOpen.Text = "Clear on Open";
        this.chkClearOnOpen.UseVisualStyleBackColor = true;
        this.chkClearOnOpen.Visible = false;
        // 
        // chkClearWithDTR
        // 
        this.chkClearWithDTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.chkClearWithDTR.AutoSize = true;
        this.chkClearWithDTR.Location = new System.Drawing.Point(95, 26);
        this.chkClearWithDTR.Name = "chkClearWithDTR";
        this.chkClearWithDTR.Size = new System.Drawing.Size(98, 17);
        this.chkClearWithDTR.TabIndex = 11;
        this.chkClearWithDTR.Text = "Clear with DTR";
        this.chkClearWithDTR.UseVisualStyleBackColor = true;
        this.chkClearWithDTR.Visible = false;
        // 
        // done
        // 
        this.done.Location = new System.Drawing.Point(619, 419);
        this.done.Name = "done";
        this.done.Size = new System.Drawing.Size(97, 36);
        this.done.TabIndex = 12;
        this.done.Text = "Exit";
        this.done.UseVisualStyleBackColor = true;
        this.done.Click += new System.EventHandler(this.done_Click);
        // 
        // see_mess
        // 
        this.see_mess.Location = new System.Drawing.Point(79, 346);
        this.see_mess.Name = "see_mess";
        this.see_mess.Size = new System.Drawing.Size(72, 27);
        this.see_mess.TabIndex = 14;
        this.see_mess.Text = "open";
        this.see_mess.UseVisualStyleBackColor = true;
        this.see_mess.Click += new System.EventHandler(this.see_mess_Click);
        // 
        // no_message
        // 
        this.no_message.Location = new System.Drawing.Point(79, 313);
        this.no_message.Multiline = true;
        this.no_message.Name = "no_message";
        this.no_message.Size = new System.Drawing.Size(68, 20);
        this.no_message.TabIndex = 15;
        this.no_message.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
        // 
        // next
        // 
        this.next.Location = new System.Drawing.Point(153, 313);
        this.next.Name = "next";
        this.next.Size = new System.Drawing.Size(52, 27);
        this.next.TabIndex = 16;
        this.next.Text = ">";
        this.next.UseVisualStyleBackColor = true;
        this.next.Click += new System.EventHandler(this.next_Click);
        // 
        // pervious
        // 
        this.pervious.Location = new System.Drawing.Point(25, 313);
        this.pervious.Name = "pervious";
        this.pervious.Size = new System.Drawing.Size(48, 27);
        this.pervious.TabIndex = 17;
        this.pervious.Text = "<";
        this.pervious.UseVisualStyleBackColor = true;
        this.pervious.Click += new System.EventHandler(this.pervious_Click);
        // 
        // delete
        // 
        this.delete.Location = new System.Drawing.Point(48, 177);
        this.delete.Name = "delete";
        this.delete.Size = new System.Drawing.Size(119, 27);
        this.delete.TabIndex = 18;
        this.delete.Text = "delete";
        this.delete.UseVisualStyleBackColor = true;
        this.delete.Click += new System.EventHandler(this.delete_Click);
        // 
        // rec_read_sent_stored
        // 
        this.rec_read_sent_stored.AutoSize = true;
        this.rec_read_sent_stored.BackColor = System.Drawing.Color.Transparent;
        this.rec_read_sent_stored.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.rec_read_sent_stored.Location = new System.Drawing.Point(16, 42);
        this.rec_read_sent_stored.Name = "rec_read_sent_stored";
        this.rec_read_sent_stored.Size = new System.Drawing.Size(151, 17);
        this.rec_read_sent_stored.TabIndex = 19;
        this.rec_read_sent_stored.Text = "recvied read , stored , sent";
        this.rec_read_sent_stored.UseVisualStyleBackColor = false;
        // 
        // rec_read_sent
        // 
        this.rec_read_sent.AutoSize = true;
        this.rec_read_sent.BackColor = System.Drawing.Color.Transparent;
        this.rec_read_sent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.rec_read_sent.Location = new System.Drawing.Point(18, 65);
        this.rec_read_sent.Name = "rec_read_sent";
        this.rec_read_sent.Size = new System.Drawing.Size(133, 17);
        this.rec_read_sent.TabIndex = 20;
        this.rec_read_sent.Text = "recivied  read and sent";
        this.rec_read_sent.UseVisualStyleBackColor = false;
        // 
        // all
        // 
        this.all.AutoSize = true;
        this.all.BackColor = System.Drawing.Color.Transparent;
        this.all.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.all.Location = new System.Drawing.Point(18, 88);
        this.all.Name = "all";
        this.all.Size = new System.Drawing.Size(35, 17);
        this.all.TabIndex = 21;
        this.all.Text = "all";
        this.all.UseVisualStyleBackColor = false;
        // 
        // all_rec_read
        // 
        this.all_rec_read.AutoSize = true;
        this.all_rec_read.BackColor = System.Drawing.Color.Transparent;
        this.all_rec_read.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.all_rec_read.Location = new System.Drawing.Point(16, 19);
        this.all_rec_read.Name = "all_rec_read";
        this.all_rec_read.Size = new System.Drawing.Size(86, 17);
        this.all_rec_read.TabIndex = 22;
        this.all_rec_read.Text = "recivied read";
        this.all_rec_read.UseVisualStyleBackColor = false;
        // 
        // del_msg_nubmer
        // 
        this.del_msg_nubmer.AutoSize = true;
        this.del_msg_nubmer.BackColor = System.Drawing.Color.Transparent;
        this.del_msg_nubmer.Checked = true;
        this.del_msg_nubmer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.del_msg_nubmer.Location = new System.Drawing.Point(18, 113);
        this.del_msg_nubmer.Name = "del_msg_nubmer";
        this.del_msg_nubmer.Size = new System.Drawing.Size(74, 17);
        this.del_msg_nubmer.TabIndex = 23;
        this.del_msg_nubmer.TabStop = true;
        this.del_msg_nubmer.Text = "by number";
        this.del_msg_nubmer.UseVisualStyleBackColor = false;
        this.del_msg_nubmer.CheckedChanged += new System.EventHandler(this.del_msg_nubmer_CheckedChanged);
        // 
        // msg_nubmer
        // 
        this.msg_nubmer.Location = new System.Drawing.Point(103, 113);
        this.msg_nubmer.Name = "msg_nubmer";
        this.msg_nubmer.Size = new System.Drawing.Size(100, 20);
        this.msg_nubmer.TabIndex = 24;
        // 
        // groupBox2
        // 
        this.groupBox2.BackColor = System.Drawing.Color.Transparent;
        this.groupBox2.Controls.Add(this.rec_read_sent_stored);
        this.groupBox2.Controls.Add(this.msg_nubmer);
        this.groupBox2.Controls.Add(this.all);
        this.groupBox2.Controls.Add(this.del_msg_nubmer);
        this.groupBox2.Controls.Add(this.delete);
        this.groupBox2.Controls.Add(this.all_rec_read);
        this.groupBox2.Controls.Add(this.rec_read_sent);
        this.groupBox2.Location = new System.Drawing.Point(436, 68);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new System.Drawing.Size(224, 210);
        this.groupBox2.TabIndex = 25;
        this.groupBox2.TabStop = false;
        this.groupBox2.Text = "delete box";
        // 
        // center
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
        this.ClientSize = new System.Drawing.Size(728, 461);
        this.Controls.Add(this.groupBox2);
        this.Controls.Add(this.pervious);
        this.Controls.Add(this.done);
        this.Controls.Add(this.next);
        this.Controls.Add(this.no_message);
        this.Controls.Add(this.see_mess);
        this.Controls.Add(this.btnClear);
        this.Controls.Add(this.groupBox1);
        this.Controls.Add(this.gbPortSettings);
        this.Controls.Add(this.btnOpenPort);
        this.Controls.Add(this.btnSend);
        this.Controls.Add(this.gbMode);
        this.Controls.Add(this.lblSend);
        this.Controls.Add(this.rtfTerminal);
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.MinimumSize = new System.Drawing.Size(505, 250);
        this.Name = "center";
        this.Text = "SerialPort Terminal";
        this.Load += new System.EventHandler(this.frmTerminal_Load);
        this.Shown += new System.EventHandler(this.frmTerminal_Shown);
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTerminal_FormClosing);
        this.gbMode.ResumeLayout(false);
        this.gbMode.PerformLayout();
        this.gbPortSettings.ResumeLayout(false);
        this.gbPortSettings.PerformLayout();
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.groupBox2.ResumeLayout(false);
        this.groupBox2.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RichTextBox rtfTerminal;
    private System.Windows.Forms.TextBox txtSendData;
    private System.Windows.Forms.Label lblSend;
    private System.Windows.Forms.Button btnSend;
    private System.Windows.Forms.ComboBox cmbPortName;
    private System.Windows.Forms.ComboBox cmbBaudRate;
    private System.Windows.Forms.RadioButton rbHex;
    private System.Windows.Forms.RadioButton rbText;
    private System.Windows.Forms.GroupBox gbMode;
    private System.Windows.Forms.Label lblComPort;
    private System.Windows.Forms.Label lblBaudRate;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cmbParity;
    private System.Windows.Forms.Label lblDataBits;
    private System.Windows.Forms.ComboBox cmbDataBits;
    private System.Windows.Forms.Label lblStopBits;
    private System.Windows.Forms.ComboBox cmbStopBits;
    private System.Windows.Forms.Button btnOpenPort;
    private System.Windows.Forms.GroupBox gbPortSettings;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox chkCD;
		private System.Windows.Forms.CheckBox chkDSR;
		private System.Windows.Forms.CheckBox chkCTS;
		private System.Windows.Forms.CheckBox chkDTR;
		private System.Windows.Forms.CheckBox chkRTS;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.CheckBox chkClearOnOpen;
        private System.Windows.Forms.CheckBox chkClearWithDTR;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Button see_mess;
        private System.Windows.Forms.TextBox no_message;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button pervious;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.RadioButton rec_read_sent_stored;
        private System.Windows.Forms.RadioButton rec_read_sent;
        private System.Windows.Forms.RadioButton all;
        private System.Windows.Forms.RadioButton all_rec_read;
        private System.Windows.Forms.RadioButton del_msg_nubmer;
        private System.Windows.Forms.TextBox msg_nubmer;
        private System.Windows.Forms.GroupBox groupBox2;
  }
}

