using System;
using System.Windows.Forms;


namespace Delegations
{
    static class Program
    {
        public static Autentication auth;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }

    }
}
