using System;
using System.Windows.Forms;

namespace Delegations
{
    public partial class NewUserForm : Form
    {
        private readonly ILoger loger = new ConsoleLoger();
        private readonly ILoger warningbox = new ErrorBox();
        private readonly ILoger infologer = new InfoBox();
 
 

        public NewUserForm()
        {
            InitializeComponent();
            this.MdiParent = MainForm.ActiveForm;
            this.Show();
            FillForm();
        }
  

        private void FillForm()
        {
            var departaments = new Departaments().Get();
            var roles = new Roles().Get();
 

            foreach (var department in departaments)
            {
                this.departamentComboBox.Items.Add(new ComboboxItem( department.full_name, department.Id));
            }

            foreach (var role in roles)
            {
                this.rolaComboBox.Items.Add(new ComboboxItem( role.role_name, role.Id));
                    
            }
        }

        private Boolean ValidateForm()
        {

            string msg;

            if (String.IsNullOrEmpty(this.imieTexBox.Text))
            {
                msg = "Uzupełnij imię";
                this.loger.Write(msg);
                this.warningbox.Write(msg);
                return false;

            }
            else if (String.IsNullOrEmpty(this.nazwiskoTextBox.Text))
            {
                msg = "Uzupełnij nazwisko";
                this.loger.Write(msg);
                this.warningbox.Write(msg);
                return false;

            }
            else if (String.IsNullOrEmpty(this.loginTextBox.Text))
            {
                msg = "Uzupełnij login";
                this.loger.Write(msg);
                this.warningbox.Write(msg);
                return false;

            }
            else if (String.IsNullOrEmpty(this.departamentComboBox.Text))
            {
                msg = "Wybierz departament";
                this.loger.Write(msg);
                this.warningbox.Write(msg);
                return false;

            }
            else if (String.IsNullOrEmpty(this.rolaComboBox.Text))
            {
                msg = "Wybierz rolę";
                this.loger.Write(msg);
                this.warningbox.Write(msg);
                return false;

            }
            else if (String.IsNullOrEmpty(this.newPasswordtextBox.Text) || String.IsNullOrEmpty(this.confirmPasswordTextBox.Text))
            {
                msg = "Wprowadz nowe hasło";
                this.loger.Write(msg);
                this.warningbox.Write(msg);
                return false;

            }
            else if (this.confirmPasswordTextBox.Text != this.newPasswordtextBox.Text || this.newPasswordtextBox.Text != this.confirmPasswordTextBox.Text)
            {
                msg = "Wpisane hasła są różne";
                this.loger.Write(msg);
                this.warningbox.Write(msg);
                return false;
            }

            return true;

        }

        private void AddNewUserButton_Click(object sender, EventArgs e)
        {
            
            if(ValidateForm())
            {
                DateTime localDate = DateTime.Now;
                int status = this.statusCheckBox.Checked ?  0 : 1;

                var password = new PasswordHasher();
                string hash = password.Hash(this.newPasswordtextBox.Text);

                var selectedDepartment = departamentComboBox.SelectedItem as ComboboxItem;
                var selectedRole= rolaComboBox.SelectedItem as ComboboxItem;

                var department = new Departaments().Find((int)selectedDepartment.Value);
                var role = new Roles().Find((int)selectedRole.Value);

                var row_id = new Users().Add(new
                {
                    name = this.imieTexBox.Text,
                    surname = this.nazwiskoTextBox.Text,
                    login = this.loginTextBox.Text,
                    password = hash,
                    department = department.Id,
                    role = role.Id,
                    status = status,
                    created_at = localDate,
                });

                
                if (row_id > 0)
                { 
                    infologer.Write("Użytkownik został dodany"); 
                }
 
                this.Close();



            }
        }
    }
}
