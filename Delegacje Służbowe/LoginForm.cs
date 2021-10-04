using System;
using System.Drawing;
using System.Windows.Forms;

namespace Delegations
{
    public partial class LoginForm : Form
    {
        private readonly ILoger loger = new ConsoleLoger();
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + $@"{Application.StartupPath}Database.mdf;" + @"Integrated Security=True;Connect Timeout=30";


        public LoginForm()
        {
            InitializeComponent();
            IConnection db_con = new LocalDB();
            var con = db_con.Connect(connectionString);

            if (db_con.Status(con))
            {
                this.conectionStatusLabel.Text = "Połączono z bazą";
                this.conectionStatusLabel.ForeColor = Color.Green;
                db_con.Disconnect(con);
            }
            else
            {
                this.conectionStatusLabel.Text = "Brak połączenia z bazą";
                this.conectionStatusLabel.ForeColor = Color.Red;
            }

        }


        private void LoginButton_Click(object sender, EventArgs e)
        { 
            string login = this.loginTextBox.Text;
            string passowrd = this.passwordTextBox.Text;
            string msg;

            var autenticate = new Autentication();
 
            if (autenticate.Login(login, passowrd))
            {
                this.Hide();
                var mainform = new MainForm(autenticate.GetID());
                mainform.FormClosed += (s, args) => this.Close();
                loger.Write("Autoryzacja poprawna");                 

            } else
            {
                msg = "Niepoprawne dane autoryzujące";
                loger.Write(msg);
                this.conectionStatusLabel.ForeColor = Color.Red;
                this.conectionStatusLabel.Text = msg;
            }
        } 
    }
}
