using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace SerialPortTerminal
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.Run(new start());

      /////////////////////////////////////// // odbc connection db2
      OdbcConnection conn = new OdbcConnection();
      conn.ConnectionString =
                    "Dsn=db2;" +
                    "Uid=db2admin;" +
                    "Pwd=db2admin;";
      conn.Open();
      /////////////////////////////////////////////////
      
        ///////////////////////////////////////

    }
  }
}