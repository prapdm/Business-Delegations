using System;
using System.Windows.Forms;
using SqlKata.Compilers;
using SqlKata.Execution;


namespace Delegacje_Służbowe
{
    public partial class UsersList : Form
    {
        public UsersList()
        {
            InitializeComponent();
            FillDataGrid();
        }
 

        public void FillDataGrid()
        {
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.AutoGenerateColumns = false;
            var compiler = new SqlServerCompiler();
            var db = new QueryFactory(Program.conn.con, compiler);
            var users = db.Query("Users").Join("Roles", "Roles.Id", "Users.role").Join("Departments", "Departments.Id", "Users.department").Get();

            String Status;
 
                foreach (var user in users)
                {
                    if (user.Status == 1)
                        Status = "Aktywny";
                    else
                        Status = "Nieaktywny";

                    this.dataGridView1.Rows.Add(user.Id, user.name, user.surname, user.login, user.full_name, user.role_name, Status, user.created_at, user.updated_at);
                
                }
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            string user_id_s = row.Cells[0].Value.ToString();
            int user_id = int.Parse(user_id_s);

            //Debug.WriteLine(user_id);

            new EditUser(user_id);
         



        }

      

        private void DataGridView1_MouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            ContextMenuStrip m = new ContextMenuStrip();
            m.Items.Add("Odśwież");
            m.Items.Add("Pokaż");
            m.Items.Add("Usuń");

            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            // Ignore if a column or row header is clicked
            if (rowIndex != -1 && columnIndex != -1)
            {
                if (e.Button == MouseButtons.Right)
                {
                    DataGridViewCell clickedCell = (sender as DataGridView).Rows[rowIndex].Cells[columnIndex];
                    

                    // Here you can do whatever you want with the cell
                    dataGridView1.CurrentCell = clickedCell;  // Select the clicked cell, for instance

                    // Get mouse position relative to the vehicles grid
                    var relativeMousePosition = dataGridView1.PointToClient(Cursor.Position);

                    // Show the context menu
                    m.Show(dataGridView1, relativeMousePosition);

                   
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];
                  
                    string user_id_s = row.Cells[0].Value.ToString();
                    int user_id = int.Parse(user_id_s);

                    //pass user_id to contexMenu_ItemClicked event using lambda expression
                    m.ItemClicked += (sender, e) => { ContexMenu_ItemClicked(sender, e, user_id); };
                   

                }
            }

        }

        void ContexMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e, int user_id)
        {

            

            if (e.ClickedItem.ToString() == "Pokaż")
            {

                 new EditUser(user_id);
                 
            }
            else if (e.ClickedItem.ToString() == "Odśwież")
            {

                this.FillDataGrid();

            }

            else if(e.ClickedItem.ToString() == "Usuń")
            {
                DialogResult result = MessageBox.Show("Usunięcie użytkownika", "Czy napewno chcesz usunąć tego użytkownika?",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning);

                if(result.ToString() == "Yes")
                {
                    User user = new User();
                    user.DeleteUser(user_id,this);
                }

            }




        }

        private void NewUserbutton_Click(object sender, EventArgs e)
        {
            new NewUser(this);
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            string search = this.SearchTextBox.Text;
            var compiler = new SqlServerCompiler();
            var db = new QueryFactory(Program.conn.con, compiler);
            String Status;

            if (!String.IsNullOrEmpty(search))
            {



                var users = db.Query("Users").Join("Roles", "Roles.Id", "Users.role").Join("Departments", "Departments.Id", "Users.department").Where(q =>
                                q.WhereLike("name", $"%{search}%").OrWhereLike("surname", $"%{search}%")
                            ).OrWhere(q =>
                                q.WhereLike("login", $"%{search}%").OrWhereLike("Departments.full_name", $"%{search}%")
                            ).OrWhere(q =>
                                q.WhereLike("Roles.role_name", $"%{search}%")
                            ).Get();


                

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
                var users = db.Query("Users").Join("Roles", "Roles.Id", "Users.role").Join("Departments", "Departments.Id", "Users.department").Get();
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

        private void PrintButton_Click(object sender, EventArgs e)
        {
            ExportClass export = new ExportClass(this.dataGridView1, "users");
            export.PrintPDF();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            ExportClass export = new ExportClass(this.dataGridView1, "users");
            export.ExportCSV();
        }
    }
}
