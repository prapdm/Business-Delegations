using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using SqlKata.Compilers;
using SqlKata.Execution;

namespace Delegacje_Służbowe
{
    public partial class ChangePassword : Form
    {
        private readonly int user_id;

        public ChangePassword(int user_id)
        {
            InitializeComponent();
            this.MdiParent = MainForm.ActiveForm;
            this.Show();
             
            this.user_id = user_id;


            
             
        }

        public void ChangePasswordUser()
        {
            Debug.WriteLine(this.user_id);
            User user = new User();
            string newpassword = this.newPasswordtextBox.Text;
            string hash = user.PasswordHash(newpassword);

            var compiler = new SqlServerCompiler();
            var db = new QueryFactory(Program.conn.con, compiler);

            var affected = db.Query("Users").Where("Id", this.user_id).Update(new
            {
                password = hash,
                
            }); 

            if (affected == 1)
            {
                this.confirmLabelPassword.Text = "Hasło zostało zmienione";
                this.confirmLabelPassword.ForeColor = Color.Green;
            }

        }

        private void SaveNewPasswordButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.newPasswordtextBox.Text) || String.IsNullOrEmpty(this.confirmPasswordTextBox.Text))
                MessageBox.Show("Wprowadz nowe hasło", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(this.confirmPasswordTextBox.Text != this.newPasswordtextBox.Text || this.newPasswordtextBox.Text !=  this.confirmPasswordTextBox.Text)
                MessageBox.Show("Wpisane hasła są różne", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                ChangePasswordUser();

        }
    }
}
