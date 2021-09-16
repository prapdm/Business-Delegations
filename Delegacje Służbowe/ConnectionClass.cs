using System.Data.SqlClient;
using System.Windows.Forms;



namespace Delegacje_Służbowe
{
    class ConnectionClass
    {

        public SqlConnection con;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + $@"{Application.StartupPath}\Database.mdf;" + @"Integrated Security=True;Connect Timeout=30";

        public ConnectionClass()
        {
            if ((con = OpenConnection()) == null)
            {
                this.Dispose();
            }

        }
        private SqlConnection OpenConnection()
        {
             
            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                con.Open();
                
            }
            catch (SqlException ex)
            {
                DisplaySqlErrors(ex);
            }

            return con;
        }

        private static void DisplaySqlErrors(SqlException exception)
        {

            string errors = "";
            for (int i = 0; i < exception.Errors.Count; i++)
            {
                
                errors+= "Index #" + i + "\n" + "Error: " + exception.Errors[i].ToString() + "\n";
            }
            MessageBox.Show(errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
