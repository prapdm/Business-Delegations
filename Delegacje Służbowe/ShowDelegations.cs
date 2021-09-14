using System;
using System.Windows.Forms;
using SqlKata.Compilers;
using SqlKata.Execution;


namespace Delegacje_Służbowe
{
    public partial class ShowDelegations : Form
    {
 

        public ShowDelegations()
        {
            InitializeComponent();
            this.MdiParent = MainForm.ActiveForm;
            this.Show();
            FillDataGrid();
        }

        public void FillDataGrid()
        {
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.AutoGenerateColumns = false;
            var compiler = new SqlServerCompiler();
            var db = new QueryFactory(Program.conn.con, compiler);
            var delegations = db.Query("Delegations AS dl").Join("Users AS u", "u.Id", "dl.user_id").Join("Departments AS dp", "dl.Id", "dp.Id").Get();



            foreach (var delelegation in delegations)
            {
                

                this.dataGridView1.Rows.Add(delelegation.Id, delelegation.name, delelegation.surname,
                    delelegation.from_date, delelegation.to_date, delelegation.full_name, delelegation.target, delelegation.created_at, delelegation.updated_at);

            }
        }

    



        void ContexMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e, int delegation_id)
        {



            if (e.ClickedItem.ToString() == "Pokaż")
            {

                new EditDelegation(delegation_id);

            }
            else if (e.ClickedItem.ToString() == "Odśwież")
            {

                this.FillDataGrid();

            }

            else if (e.ClickedItem.ToString() == "Usuń")
            {
                DialogResult result = MessageBox.Show("Usunięcie użytkownika", "Czy napewno chcesz usunąć tego użytkownika?",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning);

                if (result.ToString() == "Yes")
                {
                    var compiler = new SqlServerCompiler();
                    var db = new QueryFactory(Program.conn.con, compiler);
                    int affected = db.Query("Delegations").Where("Id", delegation_id).Delete();

                    if (affected == 1)
                    {
                        MessageBox.Show("Delegacja o identyfikatorze " + delegation_id + " została usunięta.", "Potwierdzenie usunięcia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        this.FillDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Delegacja o identyfikatorze " + delegation_id + " nie została usunięta.", "Błąd",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    }
                }

            }




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

                    string delegation_id_s = row.Cells[0].Value.ToString();
                    int delegation_id = int.Parse(delegation_id_s);
                   

                    //pass user_id to contexMenu_ItemClicked event using lambda expression
                    m.ItemClicked += (sender, e) => { ContexMenu_ItemClicked(sender, e, delegation_id); };


                }
            }

        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            string search = this.SearchTextBox.Text;
            
       

            var compiler = new SqlServerCompiler();
            var db = new QueryFactory(Program.conn.con, compiler);

         

            if (!String.IsNullOrEmpty(search) )
            {
                
                   
                    var delegations = db.Query("Delegations AS dl").Join("Users AS u", "u.Id", "dl.user_id").Join("Departments AS dp", "dl.Id", "dp.Id").Where(q =>
                           q.WhereLike("u.name", $"%{search}%").OrWhereLike("u.surname", $"%{search}%")
                       ).OrWhere(q =>
                           q.WhereLike("dp.full_name", $"%{search}%").OrWhereLike("dl.target", $"%{search}%")
                       ).WhereDate("dl.from_date", ">=", this.OddateTimePicker.Value).WhereDate("dl.to_date", "<=", this.DodateTimePicker.Value).Get();

                this.dataGridView1.Rows.Clear();
                foreach (var delelegation in delegations)
                {
                     
                    this.dataGridView1.Rows.Add(delelegation.Id, delelegation.name, delelegation.surname,
                          delelegation.from_date, delelegation.to_date, delelegation.full_name, delelegation.target, delelegation.created_at, delelegation.updated_at);
                }






            }
            else
            {
                var delegations = db.Query("Delegations AS dl").Join("Users AS u", "u.Id", "dl.user_id").Join("Departments AS dp", "dl.Id", "dp.Id").WhereDate("dl.from_date", ">=", this.OddateTimePicker.Value)
                    .WhereDate("dl.to_date", "<=", this.DodateTimePicker.Value).Get();
                this.dataGridView1.Rows.Clear();
                 
                foreach (var delelegation in delegations)
                {
                 
                    this.dataGridView1.Rows.Add(delelegation.Id, delelegation.name, delelegation.surname,
                          delelegation.from_date, delelegation.to_date, delelegation.full_name, delelegation.target, delelegation.created_at, delelegation.updated_at);
                }
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            ExportClass export = new ExportClass(this.dataGridView1, "delegations");
            export.PrintPDF();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            ExportClass export = new ExportClass(this.dataGridView1, "delegations");
            export.ExportCSV();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            string delegation_id_s = row.Cells[0].Value.ToString();
            int delegation_id = int.Parse(delegation_id_s);
 

            new EditDelegation(delegation_id);

        }
    }
}
