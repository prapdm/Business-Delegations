using System;
using System.Windows.Forms;
using SqlKata.Compilers;
using SqlKata.Execution;


namespace Delegacje_Służbowe
{
    public partial class DetailsRole : Form
    {

        private readonly string role_name;

        public DetailsRole()
        {
            InitializeComponent();
            this.MdiParent = MainForm.ActiveForm;
            this.Show();
            this.Fill();
        }

        public DetailsRole(string role_name)
        {
            InitializeComponent();
            this.MdiParent = MainForm.ActiveForm;
            this.Show();
            this.role_name = role_name;
            this.Fill();
        }

        public void Fill()
        {
            var db = new QueryFactory(Program.conn.con, new SqlServerCompiler());
            var role = db.Query("Roles").Where("role_name", role_name).FirstOrDefault();

            label1.Text = $"Edycja roli \"{role_name}\" ";

            bool add_new_user, modify_user, delete_user, view_users, add_delegation, modify_delegation,
                delete_delegation, view_delegation, add_departments, del_departments, add_roles, del_roles, modify_role;

            if (role.add_new_user == 1) add_new_user = true; else add_new_user = false;
            if (role.modify_user == 1) modify_user = true; else modify_user = false;
            if (role.delete_user == 1) delete_user = true; else delete_user = false;
            if (role.view_users == 1) view_users = true; else view_users = false;
            if (role.add_delegation == 1) add_delegation = true; else add_delegation = false;
            if (role.modify_delegation == 1) modify_delegation = true; else modify_delegation = false;
            if (role.delete_delegation == 1) delete_delegation = true; else delete_delegation = false;
            if (role.view_delegation == 1) view_delegation = true; else view_delegation = false;
            if (role.add_departments == 1) add_departments = true; else add_departments = false;
            if (role.del_departments == 1) del_departments = true; else del_departments = false;
            if (role.add_roles == 1) add_roles = true; else add_roles = false;
            if (role.del_roles == 1) del_roles = true; else del_roles = false;
            if (role.modify_role == 1) modify_role = true; else modify_role = false;

            RolecheckedListBox.Items.Add("Dodawanie nowego użytkownika", add_new_user);
            RolecheckedListBox.Items.Add("Edytowanie użytkowników", modify_user);
            RolecheckedListBox.Items.Add("Wyświetlanie użytkowników", view_users);
            RolecheckedListBox.Items.Add("Usuwanie użytkowników", delete_user);
            RolecheckedListBox.Items.Add("Dodawanie departamentów", add_departments);
            RolecheckedListBox.Items.Add("Usuwanie depeartamentów", del_departments);
            RolecheckedListBox.Items.Add("Dodawanie roli", add_roles);
            RolecheckedListBox.Items.Add("Modyfikowanie roli", modify_role);
            RolecheckedListBox.Items.Add("Usuwanie roli", del_roles);
            RolecheckedListBox.Items.Add("Dodawanie delegacji", add_delegation);
            RolecheckedListBox.Items.Add("Modyfikowanie delegacji", modify_delegation);
            RolecheckedListBox.Items.Add("Wyświetlanie delegacji", view_delegation);
            RolecheckedListBox.Items.Add("Usuwanie delegacji", delete_delegation);

        }

        private void Zapiszbutton_Click(object sender, EventArgs e)
        {
            var db = new QueryFactory(Program.conn.con, new SqlServerCompiler());
           

            
            var affected = db.Query("Roles").Where("role_name", role_name).Update(new
            {
                add_new_user = (bool)RolecheckedListBox.GetItemChecked(0),
                modify_user = (bool)RolecheckedListBox.GetItemChecked(1),
                view_users = (bool)RolecheckedListBox.GetItemChecked(2),
                delete_user = (bool)RolecheckedListBox.GetItemChecked(3),
                add_departments = (bool)RolecheckedListBox.GetItemChecked(4),
                del_departments = (bool)RolecheckedListBox.GetItemChecked(5),
                add_roles = (bool)RolecheckedListBox.GetItemChecked(6),
                modify_role = (bool)RolecheckedListBox.GetItemChecked(7),
                del_roles = (bool)RolecheckedListBox.GetItemChecked(8),
                add_delegation = (bool)RolecheckedListBox.GetItemChecked(9),
                modify_delegation = (bool)RolecheckedListBox.GetItemChecked(10),
                view_delegation = (bool)RolecheckedListBox.GetItemChecked(11),
                delete_delegation = (bool)RolecheckedListBox.GetItemChecked(12),


            });



            if(affected == 1)
            {
                MessageBox.Show("Dane zapisane", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}