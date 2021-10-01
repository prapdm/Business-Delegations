using System;
using System.Windows.Forms;

namespace Delegations
{
    public partial class UsersListForm : Form
    {

        private readonly int loged_user;
        private readonly Users u;
        private ContextMenuStrip m;
        private readonly WarningBox warning = new WarningBox(); 

        public UsersListForm(int loged_user_id)
        {
            InitializeComponent();
            this.MdiParent = MainForm.ActiveForm;
            this.Show();
            this.loged_user = loged_user_id;
            this.u = new Users();
            FillDataGrid();             
        }
 
        public void FillDataGrid()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.AutoGenerateColumns = false;
            this.m = new ContextMenuStrip();
            var users = u.Get();

            m.Items.Add("Odśwież");
            m.Items.Add("Pokaż");

            String Status;
 
                foreach (var user in users)
                {
                    if (user.Status == 1)
                        Status = "Aktywny";
                    else
                        Status = "Nieaktywny";

                    this.dataGridView1.Rows.Add(user.Id, user.name, user.surname, user.login, user.full_name, user.role_name, Status, user.created_at, user.updated_at);
                
                }
            CheckFormAccess();
        }

        private void CheckFormAccess()
        {
            var user = u.Find(loged_user);
            if (user.add_new_user == 0) 
                this.newUserbutton.Enabled = false;

            if (user.delete_user == 1)  
                 m.Items.Add("Usuń");
         
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            string user_id_s = row.Cells[0].Value.ToString();
            int user_id = int.Parse(user_id_s);
            var edituser = new EditUserForm(user_id);
            edituser.FormClosed += (s, args) => this.FillDataGrid();
        }

      

        private void DataGridView1_MouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            if (rowIndex != -1 && columnIndex != -1)
            {
                if (e.Button == MouseButtons.Right)
                {
                    DataGridViewCell clickedCell = (sender as DataGridView).Rows[rowIndex].Cells[columnIndex];
                    dataGridView1.CurrentCell = clickedCell;  
                    var relativeMousePosition = dataGridView1.PointToClient(Cursor.Position);
                    m.Show(dataGridView1, relativeMousePosition);
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];

                    string user_id_s = row.Cells[0].Value.ToString();
                    int user_id = int.Parse(user_id_s);

                    m.ItemClicked += (sender1, e1) => { ContexMenu_ItemClicked(sender1, e1, user_id); };
                }
            }

        }

        void ContexMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e, int user_id)
        {
              
            if (e.ClickedItem.ToString() == "Pokaż")
            {
                 var edituser = new EditUserForm(user_id);
                 edituser.FormClosed += (s, args) => this.FillDataGrid();
                 m.Hide();
            }
            else if (e.ClickedItem.ToString() == "Odśwież")
            {
                this.FillDataGrid();
                m.Hide();
            }

            else if(e.ClickedItem.ToString() == "Usuń")
            {
               
                var result = warning.Write("Czy napewno chcesz usunąć tego użytkownika?");
                m.Hide();
                if (result.ToString() == "Yes")
                {
                    var users = new Users().Delete(user_id);
                }
                this.FillDataGrid();
            }
        }

        private void NewUserbutton_Click(object sender, EventArgs e)
        {
           var newuserform = new NewUserForm();
           newuserform.FormClosed += (s, args) => this.FillDataGrid();

        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            string search = this.SearchTextBox.Text;
            String Status;

            if (!String.IsNullOrEmpty(search))
            {

                var users = new Users().Filter(new { word = search });

                this.dataGridView1.Rows.Clear();
                foreach (var user in users)
                {

                    if (user.Status == 1)
                        Status = "Aktywny";
                    else
                        Status = "Nieaktywny";

                    this.dataGridView1.Rows.Add(user.Id, user.name, user.surname, user.login, user.full_name, user.role_name, Status, user.created_at, user.updated_at);

                }       
            }
            else
            {
                var users = new Users().Get();
                this.dataGridView1.Rows.Clear();
                foreach (var user in users)
                {
                    if (user.Status == 1)
                        Status = "Aktywny";
                    else
                        Status = "Nieaktywny";

                    this.dataGridView1.Rows.Add(user.Id, user.name, user.surname, user.login, user.full_name, user.role_name, Status, user.created_at, user.updated_at);
                }
            }
        }

        private void ExportToPDF_Click(object sender, EventArgs e)
        {
            ExportToFile export = new ExportToFile(this.dataGridView1, "users", new SaveToPDF());
            export.Save();
        }

        private void ExportToCSV_Click(object sender, EventArgs e)
        {
            ExportToFile export = new ExportToFile(this.dataGridView1, "users", new SaveToCSV());
            export.Save();
        }
    }
}
