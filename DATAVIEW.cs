using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO.Ports;
using SerialPortTerminal.Properties;
using System.Threading;


namespace SerialPortTerminal
{
    public partial class DATAVIEW : Form
    {
        public DATAVIEW()
        {
            InitializeComponent();

        }

        private void DATAVIEW_Load(object sender, EventArgs e)
        {

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
                    string strSql = "select * from MESSAGE_CENTER";
                    OdbcDataAdapter dadapter = new OdbcDataAdapter();
                    dadapter.SelectCommand = new OdbcCommand(strSql, conn);
                    DataSet dset = new DataSet();
                    dadapter.Fill(dset);
                    conn.Close();
                    this.dataGridView1.DataSource = dset;

                

               
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
