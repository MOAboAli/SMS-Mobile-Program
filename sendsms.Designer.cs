namespace SerialPortTerminal
{
  partial class sendsms
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
        this.components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sendsms));
        this.rtfTerminal = new System.Windows.Forms.RichTextBox();
        this.txtSendData = new System.Windows.Forms.TextBox();
        this.lblSend = new System.Windows.Forms.Label();
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
        this.tmrCheckComPorts = new System.Windows.Forms.Timer(this.components);
        this.toolTip = new System.Windows.Forms.ToolTip(this.components);
        this.done = new System.Windows.Forms.Button();
        this.select_db = new System.Windows.Forms.RadioButton();
        this.enter_no = new System.Windows.Forms.RadioButton();
        this.year_text = new System.Windows.Forms.TextBox();
        this.spc_text = new System.Windows.Forms.TextBox();
        this.number_sms = new System.Windows.Forms.TextBox();
        this.message_text = new System.Windows.Forms.RichTextBox();
        this.send_text = new System.Windows.Forms.Button();
        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.label3 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
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
        this.rtfTerminal.Size = new System.Drawing.Size(419, 341);
        this.rtfTerminal.TabIndex = 0;
        this.rtfTerminal.Text = "";
        this.rtfTerminal.TextChanged += new System.EventHandler(this.rtfTerminal_TextChanged);
        // 
        // txtSendData
        // 
        this.txtSendData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.txtSendData.Location = new System.Drawing.Point(282, 551);
        this.txtSendData.Name = "txtSendData";
        this.txtSendData.Size = new System.Drawing.Size(0, 20);
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
        this.lblSend.Location = new System.Drawing.Point(282, 531);
        this.lblSend.Name = "lblSend";
        this.lblSend.Size = new System.Drawing.Size(61, 13);
        this.lblSend.TabIndex = 1;
        this.lblSend.Text = "Send &Data:";
        this.lblSend.Visible = false;
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
        this.rbText.Location = new System.Drawing.Point(12, 19);
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
        this.gbMode.Location = new System.Drawing.Point(6, 513);
        this.gbMode.Name = "gbMode";
        this.gbMode.Size = new System.Drawing.Size(89, 64);
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
        this.btnOpenPort.Location = new System.Drawing.Point(725, 462);
        this.btnOpenPort.Name = "btnOpenPort";
        this.btnOpenPort.Size = new System.Drawing.Size(107, 48);
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
        this.gbPortSettings.Location = new System.Drawing.Point(12, 508);
        this.gbPortSettings.Name = "gbPortSettings";
        this.gbPortSettings.Size = new System.Drawing.Size(374, 63);
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
        this.groupBox1.Controls.Add(this.chkClearWithDTR);
        this.groupBox1.Controls.Add(this.chkCTS);
        this.groupBox1.Controls.Add(this.chkClearOnOpen);
        this.groupBox1.Controls.Add(this.chkDTR);
        this.groupBox1.Location = new System.Drawing.Point(12, 531);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(264, 38);
        this.groupBox1.TabIndex = 7;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "&Line Signals";
        this.groupBox1.Visible = false;
        // 
        // chkRTS
        // 
        this.chkRTS.AutoSize = true;
        this.chkRTS.Location = new System.Drawing.Point(59, 19);
        this.chkRTS.Name = "chkRTS";
        this.chkRTS.Size = new System.Drawing.Size(48, 17);
        this.chkRTS.TabIndex = 1;
        this.chkRTS.Text = "RTS";
        this.toolTip.SetToolTip(this.chkRTS, "Pin 7 on DB9, Output, Request to Send");
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
        this.toolTip.SetToolTip(this.chkCD, "Pin 1 on DB9, Input, Data Carrier Detect");
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
        this.toolTip.SetToolTip(this.chkDSR, "Pin 6 on DB9, Input, Data Set Ready");
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
        this.toolTip.SetToolTip(this.chkCTS, "Pin 8 on DB9, Input, Clear to Send");
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
        this.toolTip.SetToolTip(this.chkDTR, "Pin 4 on DB9, Output, Data Terminal Ready");
        this.chkDTR.UseVisualStyleBackColor = true;
        this.chkDTR.CheckedChanged += new System.EventHandler(this.chkDTR_CheckedChanged);
        // 
        // btnClear
        // 
        this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnClear.Location = new System.Drawing.Point(349, 359);
        this.btnClear.Name = "btnClear";
        this.btnClear.Size = new System.Drawing.Size(82, 36);
        this.btnClear.TabIndex = 9;
        this.btnClear.Text = "&Clear";
        this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
        // 
        // chkClearOnOpen
        // 
        this.chkClearOnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.chkClearOnOpen.AutoSize = true;
        this.chkClearOnOpen.Location = new System.Drawing.Point(10, -4);
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
        this.chkClearWithDTR.Location = new System.Drawing.Point(10, 18);
        this.chkClearWithDTR.Name = "chkClearWithDTR";
        this.chkClearWithDTR.Size = new System.Drawing.Size(98, 17);
        this.chkClearWithDTR.TabIndex = 11;
        this.chkClearWithDTR.Text = "Clear with DTR";
        this.chkClearWithDTR.UseVisualStyleBackColor = true;
        this.chkClearWithDTR.Visible = false;
        // 
        // tmrCheckComPorts
        // 
        this.tmrCheckComPorts.Enabled = true;
        this.tmrCheckComPorts.Interval = 500;
        this.tmrCheckComPorts.Tick += new System.EventHandler(this.tmrCheckComPorts_Tick);
        // 
        // done
        // 
        this.done.Location = new System.Drawing.Point(725, 516);
        this.done.Name = "done";
        this.done.Size = new System.Drawing.Size(107, 48);
        this.done.TabIndex = 12;
        this.done.Text = "Exit";
        this.done.UseVisualStyleBackColor = true;
        this.done.Click += new System.EventHandler(this.done_Click);
        // 
        // select_db
        // 
        this.select_db.AutoSize = true;
        this.select_db.BackColor = System.Drawing.Color.Transparent;
        this.select_db.Checked = true;
        this.select_db.ForeColor = System.Drawing.SystemColors.ControlLight;
        this.select_db.Location = new System.Drawing.Point(29, 19);
        this.select_db.Name = "select_db";
        this.select_db.Size = new System.Drawing.Size(53, 17);
        this.select_db.TabIndex = 14;
        this.select_db.TabStop = true;
        this.select_db.Text = "select";
        this.select_db.UseVisualStyleBackColor = false;
        this.select_db.Click += new System.EventHandler(this.select_db_Click);
        // 
        // enter_no
        // 
        this.enter_no.AutoSize = true;
        this.enter_no.BackColor = System.Drawing.Color.Transparent;
        this.enter_no.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.enter_no.Location = new System.Drawing.Point(29, 112);
        this.enter_no.Name = "enter_no";
        this.enter_no.Size = new System.Drawing.Size(50, 17);
        this.enter_no.TabIndex = 15;
        this.enter_no.Text = "Enter";
        this.enter_no.UseVisualStyleBackColor = false;
        this.enter_no.Click += new System.EventHandler(this.enter_no_Click);
        // 
        // year_text
        // 
        this.year_text.Location = new System.Drawing.Point(161, 18);
        this.year_text.Name = "year_text";
        this.year_text.Size = new System.Drawing.Size(180, 20);
        this.year_text.TabIndex = 17;
        // 
        // spc_text
        // 
        this.spc_text.Location = new System.Drawing.Point(161, 60);
        this.spc_text.Name = "spc_text";
        this.spc_text.Size = new System.Drawing.Size(180, 20);
        this.spc_text.TabIndex = 19;
        // 
        // number_sms
        // 
        this.number_sms.Enabled = false;
        this.number_sms.Location = new System.Drawing.Point(161, 109);
        this.number_sms.Name = "number_sms";
        this.number_sms.Size = new System.Drawing.Size(180, 20);
        this.number_sms.TabIndex = 22;
        this.number_sms.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
        // 
        // message_text
        // 
        this.message_text.Location = new System.Drawing.Point(28, 157);
        this.message_text.Name = "message_text";
        this.message_text.Size = new System.Drawing.Size(346, 116);
        this.message_text.TabIndex = 23;
        this.message_text.Text = "";
        this.message_text.TextChanged += new System.EventHandler(this.message_text_TextChanged);
        // 
        // send_text
        // 
        this.send_text.ForeColor = System.Drawing.SystemColors.ControlText;
        this.send_text.Location = new System.Drawing.Point(276, 287);
        this.send_text.Name = "send_text";
        this.send_text.Size = new System.Drawing.Size(98, 48);
        this.send_text.TabIndex = 24;
        this.send_text.Text = "send";
        this.send_text.UseVisualStyleBackColor = true;
        this.send_text.Click += new System.EventHandler(this.send_text_Click);
        // 
        // groupBox2
        // 
        this.groupBox2.BackColor = System.Drawing.Color.Transparent;
        this.groupBox2.Controls.Add(this.label3);
        this.groupBox2.Controls.Add(this.label2);
        this.groupBox2.Controls.Add(this.select_db);
        this.groupBox2.Controls.Add(this.send_text);
        this.groupBox2.Controls.Add(this.number_sms);
        this.groupBox2.Controls.Add(this.message_text);
        this.groupBox2.Controls.Add(this.spc_text);
        this.groupBox2.Controls.Add(this.enter_no);
        this.groupBox2.Controls.Add(this.year_text);
        this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.groupBox2.Location = new System.Drawing.Point(437, 12);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new System.Drawing.Size(395, 341);
        this.groupBox2.TabIndex = 25;
        this.groupBox2.TabStop = false;
        this.groupBox2.Text = "send sms";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.BackColor = System.Drawing.Color.Transparent;
        this.label3.ForeColor = System.Drawing.Color.Transparent;
        this.label3.Location = new System.Drawing.Point(93, 60);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(62, 13);
        this.label3.TabIndex = 26;
        this.label3.Text = "speclization";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.BackColor = System.Drawing.Color.Transparent;
        this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        this.label2.Location = new System.Drawing.Point(120, 21);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(27, 13);
        this.label2.TabIndex = 25;
        this.label2.Text = "year";
        // 
        // sendsms
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
        this.ClientSize = new System.Drawing.Size(840, 577);
        this.Controls.Add(this.groupBox2);
        this.Controls.Add(this.done);
        this.Controls.Add(this.btnClear);
        this.Controls.Add(this.groupBox1);
        this.Controls.Add(this.gbPortSettings);
        this.Controls.Add(this.btnOpenPort);
        this.Controls.Add(this.gbMode);
        this.Controls.Add(this.lblSend);
        this.Controls.Add(this.txtSendData);
        this.Controls.Add(this.rtfTerminal);
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.MinimumSize = new System.Drawing.Size(505, 250);
        this.Name = "sendsms";
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
		private System.Windows.Forms.Timer tmrCheckComPorts;
		private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.RadioButton select_db;
        private System.Windows.Forms.RadioButton enter_no;
        private System.Windows.Forms.TextBox year_text;
        private System.Windows.Forms.TextBox spc_text;
        private System.Windows.Forms.TextBox number_sms;
        private System.Windows.Forms.RichTextBox message_text;
        private System.Windows.Forms.Button send_text;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
  }
}

