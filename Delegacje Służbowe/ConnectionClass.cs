using System.Data.SqlClient;
using System.Windows.Forms;



namespace Delegacje_Służbowe
{
    class ConnectionClass
    {

        public SqlConnection con;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + $@"{Application.StartupPath}Database.mdf;" + @"Integrated Security=True;Connect Timeout=30";

        public ConnectionClass()
        {
            if ((con = OpenConnection()) == null)
            {
                this.Dispose();
            }

        }
        private SqlConnection OpenConnection()
        {
            con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }


        public void Dispose()
        {
            if (con != null)
            {
                con.Dispose();
            }
        }




    }
}
