using System;
using System.Windows.Forms;
using Delegations;
using SqlKata.Compilers;
using SqlKata.Execution;

namespace Delegations
{
    public partial class RoleForm : Form
    {
        private readonly int loged_user;
 
        public RoleForm(int loged_user_id)
        {
            InitializeComponent();
            this.MdiParent = MainForm.ActiveForm;
            this.Show();
            this.loged_user = loged_user_id;
            Fill();
        }

        public void Fill()
        {
            var roles = new Roles().Get();
            RolelistBox.Items.Clear();

            foreach (var role in roles)
            {
                this.RolelistBox.Items.Add(new ComboboxItem(role.role_name, role.Id));

            }

            CheckFormAcces();
        }

        private void CheckFormAcces()
        {
            var  user = new Users().Find(loged_user);

            if (user.modify_role == 0) Edytujbutton.Enabled = false;
            if (user.add_roles == 0) addDodaj.Enabled = false;
            if (user.del_roles == 0) Usunbutton.Enabled = false;
        }

        private void AddDodaj_Click(object sender, EventArgs e)
        {
            var role = new RoleAddForm();
            role.FormClosed += (s, args) => this.Fill();

        }

        private void Edytujbutton_Click(object sender, EventArgs e)
        {
            if (RolelistBox.SelectedItem != null)
            {
                var selectedRole = RolelistBox.SelectedItem as ComboboxItem;
                var details = new DetailsRoleForm((int)selectedRole.Value);
                details.FormClosed += (s, args) => this.Fill();
            }
        }

        private void RolelistBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (RolelistBox.SelectedItem != null)
            {
                
                var selectedRole = RolelistBox.SelectedItem as ComboboxItem;
                var edit = new DetailsRoleForm((int)selectedRole.Value);
                edit.FormClosed += (s, args) => this.Fill();
            }
            else new WarningBox().Write("Zaznacz rolę do edycji");
        }

        private void Usunbutton_Click(object sender, EventArgs e)
        {
            if (RolelistBox.SelectedItem != null)
            {
                var selectedRole= RolelistBox.SelectedItem as ComboboxItem;
                int affected = new Roles().Delete((int)selectedRole.Value);

                if (affected == 1)
                    new InfoBox().Write("Rola \"" + RolelistBox.SelectedItem + " \" została usunięta.");
            }
            else new ErrorBox().Write("Zaznacz rolę do usunięcia");

            this.Fill();
        }
    }
}
