namespace SerialPortTerminal
{
    partial class my_messages
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
            this.txt = new System.Windows.Forms.RichTextBox();
            this.show_setting = new System.Windows.Forms.Button();
            this.read_all = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(13, 12);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(853, 195);
            this.txt.TabIndex = 0;
            this.txt.Text = "";
            this.txt.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // show_setting
            // 
            this.show_setting.Location = new System.Drawing.Point(13, 263);
            this.show_setting.Name = "show_setting";
            this.show_setting.Size = new System.Drawing.Size(151, 51);
            this.show_setting.TabIndex = 1;
            this.show_setting.Text = "show setting";
            this.show_setting.UseVisualStyleBackColor = true;
            this.show_setting.Click += new System.EventHandler(this.show_setting_Click);
            // 
            // read_all
            // 
            this.read_all.Location = new System.Drawing.Point(244, 263);
            this.read_all.Name = "read_all";
            this.read_all.Size = new System.Drawing.Size(140, 51);
            this.read_all.TabIndex = 2;
            this.read_all.Text = "Read message";
            this.read_all.UseVisualStyleBackColor = true;
            this.read_all.Click += new System.EventHandler(this.read_all_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "Read message";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // my_messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 377);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.read_all);
            this.Controls.Add(this.show_setting);
            this.Controls.Add(this.txt);
            this.Name = "my_messages";
            this.Text = "my_messages";
            this.Load += new System.EventHandler(this.my_messages_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt;
        private System.Windows.Forms.Button show_setting;
        private System.Windows.Forms.Button read_all;
        private System.Windows.Forms.Button button1;
    }
}