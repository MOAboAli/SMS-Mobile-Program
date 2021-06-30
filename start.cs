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
    public partial class start : Form
    {
           center  my_msg = new center();
          sendsms msg = new sendsms ();
          message_center terminal = new message_center();
          database_view db2_1 = new database_view(); 

        public start()
        {
            InitializeComponent();
            
        }

        private void my_messages_Click(object sender, EventArgs e)
        {

            if (my_msg.IsDisposed  == true)
            {
                 
                if (my_msg.comport.IsOpen  == true)
                    my_msg.comport.Close ();
                my_msg = new center();
                my_msg.Show();
                
            }
            else
            {
                if (my_msg.comport.IsOpen == true)
                    my_msg.comport.Close();
                my_msg = new center();
                     my_msg.Show();
                
            }
        }

        private void start_Load(object sender, EventArgs e)
        {

        }

        private void send_sms_Click(object sender, EventArgs e)
        {
            if (msg.IsDisposed == true)
            {

                if (msg.comport.IsOpen == true)
                    msg.comport.Close();
                msg = new sendsms();
                msg.Show();

            }

            else
            {
                if (msg.comport.IsOpen == true)
                    msg.comport.Close();
                msg = new sendsms();
                msg.Show();

            }
        }

        private void auto_Click(object sender, EventArgs e)
        {
            if (terminal.IsDisposed == true)
            {

                if (terminal.comport.IsOpen == true)
                    terminal.comport.Close();
                terminal = new message_center();
                terminal.Show();

            }
            else
            {
                if (terminal.comport.IsOpen == true)
                    terminal.comport.Close();
                terminal = new message_center();
                terminal.Show();

            }

            
        }

        private void DATABASE_Click(object sender, EventArgs e)
        {
            if (db2_1.Enabled == true)
            {
                db2_1 = new database_view();
                db2_1.Show();
            }
            else db2_1.Show();
           
        }

        private void Exit_1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();
            form2.Show();
        }
    }
}
