using System;
using System.Windows.Forms;
using SqlKata.Compilers;
using SqlKata.Execution;

namespace Delegacje_Służbowe
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
            this.MdiParent = MainForm.ActiveForm;
            this.Show();
            FillForm();
        }


        public void FillForm()
        {
            var compiler = new SqlServerCompiler();
            var db = new QueryFactory(Program.conn.con, compiler);
 ;

            var departaments = db.Query("Departments").Get();
            var roles = db.Query("Roles").Get();

            foreach (var department in departaments)
            {
                this.departamentComboBox.Items.Add(department.full_name);
            }
     
            foreach (var role in roles)
            {
                this.rolaComboBox.Items.Add(role.role_name);
            }


        }

        private void AddNewUser()
        {


            var compiler = new SqlServerCompiler();
            var db = new QueryFactory(Program.conn.con, compiler);
            int status;
            DateTime localDate = DateTime.Now;

            if (this.statusCheckBox.Checked)
                status = 0;
            else
                status = 1;

            User user = new User();
            string hash = user.PasswordHash(this.newPasswordtextBox.Text);


            var departament = db.Query("Departments").Where("full_name", this.departamentComboBox.Text).FirstOrDefault();
            var role = db.Query("Roles").Where("role_name", this.rolaComboBox.Text).FirstOrDefault();

            var row_id = db.Query("Users").InsertGetId<int>(new
            {
                name = this.imieTexBox.Text,
                surname = this.nazwiskoTextBox.Text,
                login = this.loginTextBox.Text,
                password = hash,
                department = departament.Id,
                role = role.Id,
                Status = status,
                updated_at = localDate,

            });

            if (row_id > 1)
            {
                this.Close();
            }

        }

        private void AddNewUserButton_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(this.imieTexBox.Text))
                MessageBox.Show("Uzupełnij imię", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (String.IsNullOrEmpty(this.nazwiskoTextBox.Text))
                MessageBox.Show("Uzupełnij nazwisko", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (String.IsNullOrEmpty(this.loginTextBox.Text))
                MessageBox.Show("Uzupełnij login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (String.IsNullOrEmpty(this.departamentComboBox.Text))
                MessageBox.Show("Wybierz departament", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (String.IsNullOrEmpty(this.rolaComboBox.Text))
                MessageBox.Show("Wybierz rolę", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (String.IsNullOrEmpty(this.newPasswordtextBox.Text) || String.IsNullOrEmpty(this.confirmPasswordTextBox.Text))
                MessageBox.Show("Wprowadz nowe hasło", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (this.confirmPasswordTextBox.Text != this.newPasswordtextBox.Text || this.newPasswordtextBox.Text != this.confirmPasswordTextBox.Text)
                MessageBox.Show("Wpisane hasła są różne", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                AddNewUser();


        }
    }
}
