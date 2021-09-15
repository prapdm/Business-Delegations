using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Delegacje_Służbowe
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static ConnectionClass conn;
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm form1 = new LoginForm();
            

            conn = new ConnectionClass();
            Debug.WriteLine(System.Data.ConnectionState.Open);
            
            if (conn.con != null &&  conn.con.State == System.Data.ConnectionState.Open)
            {
                Debug.WriteLine("Połączono z bazą");
                form1.conectionStatusLabel.ForeColor = System.Drawing.Color.Green;
                form1.conectionStatusLabel.Text = "Połączono z bazą";
            }

            Application.Run(form1);



        }

        

    }
}
