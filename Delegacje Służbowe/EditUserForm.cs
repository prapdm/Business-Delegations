using System;
using System.Windows.Forms;
using SqlKata.Compilers;
using SqlKata.Execution;
using System.Drawing;
using Delegations;

namespace Delegations
{
    public partial class EditUserForm : Form
    {
        private readonly int user_id;

        public EditUserForm(int user_id)
        {
            this.user_id = user_id;
            InitializeComponent();
            this.MdiParent = MainForm.ActiveForm;
            this.Show();
            FillForm();

        }

        public void FillForm()
        {
            var user = new Users().Find(user_id);
            var departaments = new Departaments().Get();
            var roles = new Roles().Get();

            this.imieTexBox.Text = user.name;
            this.nazwiskoTextBox.Text = user.surname;
            this.loginTextBox.Text = user.login;
            this.departamentComboBox.Text = user.full_name;
            this.rolaComboBox.Text = user.role_name;


            foreach (var department in departaments)
            {
                this.departamentComboBox.Items.Add(new ComboboxItem(department.full_name, department.Id));
            }

            foreach (var role in roles)
            {
                this.rolaComboBox.Items.Add(new ComboboxItem(role.role_name, role.Id));

            }

            departamentComboBox.SelectedIndex = departamentComboBox.FindStringExact(user.full_name);
            rolaComboBox.SelectedIndex = rolaComboBox.FindStringExact(user.role_name);

            if (user.Status == 0)
                this.statusCheckBox.Checked = true;
            else
                this.statusCheckBox.Checked = false;

        }


        private void SaveUserButton_Click(object sender, EventArgs e)
        {

            DateTime localDate = DateTime.Now;

            int status = this.statusCheckBox.Checked ? 0 : 1;

            var selectedDepartment = departamentComboBox.SelectedItem as ComboboxItem;
            var selectedRole = rolaComboBox.SelectedItem as ComboboxItem;

            var departament = new Departaments().Find((int)selectedDepartment.Value);
            var role = new Roles().Find((int)selectedRole.Value);

            var affected = new Users().Update(new
            {
                name = this.imieTexBox.Text,
                surname = this.nazwiskoTextBox.Text,
                login = this.loginTextBox.Text,
                department = departament.Id,
                role = role.Id,
                Status = status,
                updated_at = localDate,

            }, user_id);

            if (affected == 1)
            {
                this.confirmLabel.Text = "Dane zostały zaktualizowane";
                this.confirmLabel.ForeColor = Color.Green;
            }
          
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
           new ChangePasswordForm(this.user_id);
        }
    }
}
