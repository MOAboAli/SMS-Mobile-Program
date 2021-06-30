using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace SerialPortTerminal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            FileStream fs = new FileStream(@"I:\sms project\SerialPortTerminal - final 17-6-12\about.ini", FileMode.Open, FileAccess.Read);
            int file_l = (int)fs.Length ;
           byte[]    buffer =  new byte[file_l];
                fs.Read(buffer, 0, file_l);
             System.Text.Encoding enc = System.Text.Encoding.ASCII;

            string myString = enc.GetString(buffer );
            richTextBox1.Text = myString;
            fs.Close();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
