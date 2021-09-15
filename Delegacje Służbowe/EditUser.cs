using System;
using System.Windows.Forms;
using SqlKata.Compilers;
using SqlKata.Execution;
using System.Drawing;

namespace Delegacje_Służbowe
{
    public partial class EditUser : Form
    {
        private readonly int user_id;
        private readonly SqlServerCompiler compiler;
        private readonly QueryFactory db;

 

        public EditUser(int user_id)
        {
            this.user_id = user_id;
            this.compiler = new SqlServerCompiler();
            this.db = new QueryFactory(Program.conn.con, this.compiler);
            InitializeComponent();
            this.MdiParent = MainForm.ActiveForm;
            this.Show();
            FillForm();
            Permissions permissions = new Permissions(LoginForm.loged_user);
            permissions.CheckEditUserPermisions(this);
        }

        public void FillForm()
        {
            var user = db.Query("Users").Join("Roles", "Roles.Id", "Users.role").Join("Departments", "Departments.Id", "Users.department").Where("Users.id", user_id).FirstOrDefault();
            var departaments = db.Query("Departments").Get();
            var roles = db.Query("Roles").Get();


            this.imieTexBox.Text = user.name;
            this.nazwiskoTextBox.Text = user.surname;
            this.loginTextBox.Text = user.login;
            this.departamentComboBox.Text = user.full_name;
            foreach (var department in departaments)
            {
                this.departamentComboBox.Items.Add(department.full_name);
            }
            this.rolaComboBox.Text = user.role_name;
            foreach (var role in roles)
            {
                this.rolaComboBox.Items.Add(role.role_name);
            }

            if (user.Status == 0)
                this.statusCheckBox.Checked = true;
            else
                this.statusCheckBox.Checked = false;

        }


        private void SaveUserButton_Click(object sender, EventArgs e)
        {

            int status;
            DateTime localDate = DateTime.Now;

            if (this.statusCheckBox.Checked)
                status = 0;
            else
                status = 1;

             
            var departament = db.Query("Departments").Where("full_name", this.departamentComboBox.Text).FirstOrDefault();
            var role = db.Query("Roles").Where("role_name", this.rolaComboBox.Text).FirstOrDefault();

            var affected = db.Query("Users").Where("Id", this.user_id).Update(new
            {
                name = this.imieTexBox.Text,
                surname = this.nazwiskoTextBox.Text,
                login = this.loginTextBox.Text,
                department = departament.Id,
                role = role.Id,
                Status = status,
                updated_at = localDate,

            });;

            if (affected == 1)
            {
                this.confirmLabel.Text = "Dane zostały zaktualizowane";
                this.confirmLabel.ForeColor = Color.Green;
            }
          
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
           new ChangePassword(this.user_id);
        }
    }
}
