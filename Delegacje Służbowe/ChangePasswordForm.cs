using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using SqlKata.Compilers;
using SqlKata.Execution;
using Delegations;

namespace Delegations
{
    public partial class ChangePasswordForm : Form
    {
        private readonly int user_id;
   

        public ChangePasswordForm(int user_id)
        {
            InitializeComponent();
            this.MdiParent = MainForm.ActiveForm;
            this.Show();            
            this.user_id = user_id;  
        }

        public void ChangePasswordUser()
        {
            string newpassword = this.newPasswordtextBox.Text;
            string hash = new PasswordHasher().Hash(newpassword);

            var affected = new Users().Update(
                new {
                    password = hash,
                },user_id);
 
            if (affected == 1)
            {
                this.confirmLabelPassword.Text = "Hasło zostało zmienione";
                this.confirmLabelPassword.ForeColor = Color.Green;
            }
        }

        private void SaveNewPasswordButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.newPasswordtextBox.Text) || String.IsNullOrEmpty(this.confirmPasswordTextBox.Text))
                new ErrorBox().Write("Wprowadz nowe hasło");
            else if(this.confirmPasswordTextBox.Text != this.newPasswordtextBox.Text || this.newPasswordtextBox.Text !=  this.confirmPasswordTextBox.Text)
                new ErrorBox().Write("Wpisane hasła są różne");
            else
                ChangePasswordUser();

        }
    }
}
