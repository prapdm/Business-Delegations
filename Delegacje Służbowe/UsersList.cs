using System;
using System.Windows.Forms;
using SqlKata.Compilers;
using SqlKata.Execution;
using System.Diagnostics;

namespace Delegacje_Służbowe
{
    public partial class UsersList : Form
    {
        public UsersList()
        {
            InitializeComponent();
        }

        private void UsersList_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AutoGenerateColumns = false;
            var compiler = new SqlServerCompiler();
            var db = new QueryFactory(Program.conn.con, compiler);
            var users = db.Query("Users").Join("Roles", "Roles.Id", "Users.role").Get();

            String Status;

            

            foreach (var user in users)
            {
                if (user.Status == 1)
                    Status = "Aktywny";
                else
                    Status = "Nieaktywny";

                this.dataGridView1.Rows.Add(user.Id, user.name, user.surname, user.login, user.department, user.role_name, Status, user.created_at, user.updated_at);
                
            }
 

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            var user_id = row.Cells[0].Value;
            Debug.WriteLine(user_id);

            EditUser edituser = new EditUser();

            edituser.MdiParent = MainForm.ActiveForm;
            edituser.Show();

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            ContextMenuStrip m = new ContextMenuStrip();
           
            if (e.Button == MouseButtons.Right)
            {
                Debug.Write("ContextMenuStrip");
                m.Items.Add("Test2");
                m.Show();

                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    m.Items.Add(string.Format("Do something to row {0}", currentMouseOverRow.ToString()));
                }

              

            }
        }


    }
}
