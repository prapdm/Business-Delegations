using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SqlKata.Compilers;
using SqlKata.Execution;
using System.Diagnostics;
 

namespace Delegacje_Służbowe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }



        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            string login = this.loginTextBox.Text;
            string passowrd = this.passwordTextBox.Text;

            var verify_password = new User();

            var compiler = new SqlServerCompiler();
            var db = new QueryFactory(Program.conn.con, compiler);

            var user =  db.Query("Users").Where("role", 5).Where("status", 1).Where("login", login).FirstOrDefault();

            if (user != null)
            {

                if (verify_password.VerifyPassword(passowrd, user.password))
                {

                    Debug.WriteLine("Autoryzacja poprawna");
                    this.Hide();
                    MainForm mainform = new MainForm();
                    mainform.ShowDialog();
                    this.Close();

                }
                else
                {
                    Debug.WriteLine("Niepoprawne dane autoryzujące");
                    this.conectionStatusLabel.ForeColor = Color.Red;
                    this.conectionStatusLabel.Text = "Niepoprawne dane autoryzujące";
                }

            }
            else
            {
                Debug.WriteLine("Dane autoryzujące nie poprawne.");
                this.conectionStatusLabel.ForeColor = Color.Red;
                this.conectionStatusLabel.Text = "Niepoprawne dane autoryzujące";
            }




            }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = loginButton;
        }
    }
    }
