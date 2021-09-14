using System;
using System.Windows.Forms;
using SqlKata.Compilers;
using SqlKata.Execution;

namespace Delegacje_Służbowe
{
    public partial class Role : Form
    {
        public Role()
        {
            InitializeComponent();
            this.MdiParent = MainForm.ActiveForm;
            this.Show();
            this.Fill();
        }

        public void Fill()
        {
            var db = new QueryFactory(Program.conn.con, new SqlServerCompiler());
            var roles = db.Query("Roles").Get();

            RolelistBox.Items.Clear();

            foreach (var role in roles)
            {   
                RolelistBox.Items.Add(role.role_name);
            }


        }

        private void addDodaj_Click(object sender, EventArgs e)
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
                var compiler = new SqlServerCompiler();
                var db = new QueryFactory(Program.conn.con, compiler);
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
