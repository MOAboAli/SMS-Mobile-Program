using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO.Ports;
using SerialPortTerminal.Properties;
using System.Threading;
using System.Windows.Forms;

namespace SerialPortTerminal
{
    public partial class database_view : Form
    {
       
            
        public database_view()
        {
            InitializeComponent();
        }

        public void database_view_Load(object sender, EventArgs e)
        {
            data_viewing();
        }
        public void data_viewing()
        {
            // 1
            // Open connection
            OdbcConnection conn = new OdbcConnection();
            conn.ConnectionString =
                          "Dsn=db2;" +
                          "Uid=db2admin;" +
                          "Pwd=db2admin;";
            conn.Open();
            // 2
            // Create new DataAdapter
            string strSql = "select * from MOHAMED.MESSAGE_CENTER";
            OdbcDataAdapter dadapter = new OdbcDataAdapter();
            dadapter.SelectCommand = new OdbcCommand(strSql, conn);
            DataTable table_1 = new DataTable();
            dadapter.Fill(table_1);
            this.dataGridView1.DataSource = table_1;
            
            conn.Close();
            





        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
