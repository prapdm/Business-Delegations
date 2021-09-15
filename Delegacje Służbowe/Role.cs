using System;
using System.Windows.Forms;
using SqlKata.Compilers;
using SqlKata.Execution;

namespace Delegacje_Służbowe
{
    public partial class Role : Form
    {
        private readonly SqlServerCompiler compiler;
        private readonly QueryFactory db;

        public Role()
        {
            this.compiler = new SqlServerCompiler();
            this.db = new QueryFactory(Program.conn.con, this.compiler);
            InitializeComponent();
            this.MdiParent = MainForm.ActiveForm;
            this.Show();
            this.Fill();
            Permissions permissions = new Permissions(LoginForm.loged_user);
            permissions.CheckRolesPermisions(this);
        }

        public void Fill()
        {
            var roles = db.Query("Roles").Get();

            RolelistBox.Items.Clear();

            foreach (var role in roles)
            {   
                RolelistBox.Items.Add(role.role_name);
            }


        }

        private void AddDodaj_Click(object sender, EventArgs e)
        {
            new RoleAdd(this);
        }

        private void Edytujbutton_Click(object sender, EventArgs e)
        {
            if (RolelistBox.SelectedItem != null)
            {
                string curItem = RolelistBox.SelectedItem.ToString();
                new DetailsRole(curItem);
            }
        

        }

        private void RolelistBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (RolelistBox.SelectedItem != null)
            {
                string curItem = RolelistBox.SelectedItem.ToString();
                new DetailsRole(curItem);
            }
            else MessageBox.Show("Zaznacz rolę do edycji", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Usunbutton_Click(object sender, EventArgs e)
        {
            if (RolelistBox.SelectedItem != null)
            {
                string curItem = RolelistBox.SelectedItem.ToString();
                int affected = db.Query("Roles").Where("role_name", curItem).Delete();

                if (affected == 1)
                {
                    MessageBox.Show("Rola \"" + curItem + " \" została usunięta.", "Potwierdzenie usunięcia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    this.Fill();
                }

            }
            else MessageBox.Show("Zaznacz rolę do usunięcia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
