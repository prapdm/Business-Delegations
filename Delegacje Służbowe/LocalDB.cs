using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace Delegations
{
    public class LocalDB : IConnection
    {
     
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + $@"{Application.StartupPath}Database.mdf;" + @"Integrated Security=True;Connect Timeout=30";


        public SqlConnection Connect()
        {
            var con = new SqlConnection(connectionString);
            try
            {
                con.Open();

            }
            catch (SqlException ex)
            {
                string errors = "";
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errors += "Index #" + i + "\n" + "Error: " + ex.Errors[i].ToString() + "\n";
                }
               ILoger loger = new ConsoleLoger();
               loger.Write(errors);
            }

            return con;

        }

        public void Disconnect(SqlConnection con)
        {
            if (con != null)
            {
                con.Dispose();
            }
        }

        public bool Status(SqlConnection con)
        {           
            Debug.WriteLine("con.State" + con.State);
            if (con != null && con.State != ConnectionState.Closed)
                return true;
            else
                return false;
        }
    }
}
