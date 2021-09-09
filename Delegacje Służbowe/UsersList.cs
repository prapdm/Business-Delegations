using System;
using System.Windows.Forms;
using SqlKata.Compilers;
using SqlKata.Execution;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

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

            Debug.WriteLine(user_id);

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
            else
            {
                DialogResult result = MessageBox.Show("Usunięcie użytkownika", "Czy napewno chcesz usunąć tego użytkownika?",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning);

                if(result.ToString() == "Yes")
                {
                    User user = new User();
                    user.DeleteUser(user_id);
                }

            }




        }

        private void NewUserbutton_Click(object sender, EventArgs e)
        {
            new NewUser();
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

        private void printButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "użytkownicy.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = 1;

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new iTextSharp.text.Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Plik zapisany pomyślnie", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nie ma żadnych danych w tabeli!", "Info");
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "użytkownicy.csv";
                bool fileError = false;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            string csv = "";
                            int columns = dataGridView1.Columns.Count;
                            int i = 0;

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                if(i == ((columns) - 1))
                                    csv += column.HeaderText ;
                                else
                                    csv += column.HeaderText + ";";

                                i++;
                            }
                            csv += "\n";

                            i = 0;

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (i == ((columns) - 1))
                                        csv += cell.Value.ToString();
                                    else
                                        csv += cell.Value.ToString() + ";";

                                    i++;
                                    
                                    
                                }
                                csv += "\n";
                            }

                            using (StreamWriter stream = new StreamWriter(sfd.FileName))
                            {
                                stream.Write(csv);
                                stream.Close();
                            }

                            MessageBox.Show("Plik zapisany pomyślnie", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nie ma żadnych danych w tabeli!", "Info");
            }
        }
    }
}
