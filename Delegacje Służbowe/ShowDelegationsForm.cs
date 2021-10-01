using System;
using System.Windows.Forms;

namespace Delegations
{
    public partial class ShowDelegationsForm : Form
    {
        private readonly Users u;
        private readonly int loged_user;
        private ContextMenuStrip m;
        private readonly WarningBox warning = new WarningBox();

        public ShowDelegationsForm(int loged_user_id)
        {
            this.u = new Users();
            this.loged_user = loged_user_id;
            InitializeComponent();
            this.MdiParent = MainForm.ActiveForm;
            this.Show();
            FillDataGrid();

        }

        public void FillDataGrid()
        {
            this.m = new ContextMenuStrip();
            m.Items.Add("Odśwież");
            m.Items.Add("Pokaż");

            this.dataGridView1.Rows.Clear();
            this.dataGridView1.AutoGenerateColumns = false;
            var delegations = new Delegation().Get();

            foreach (var delelegation in delegations)
            {
                this.dataGridView1.Rows.Add(delelegation.Id, delelegation.name, delelegation.surname,
                    delelegation.from_date, delelegation.to_date, delelegation.full_name, delelegation.target, delelegation.created_at, delelegation.updated_at);
            }

            var lastmonth = DateTime.Today.AddMonths(-1);
            var future = DateTime.Today.AddMonths(1);
            OddateTimePicker.Value = Convert.ToDateTime(lastmonth);
            DodateTimePicker.Value = Convert.ToDateTime(future);

            CheckFormAcces();
        }


        private void CheckFormAcces()
        {
            var user = u.Find(loged_user);

            if (user.add_delegation == 0) 
                newDelegationbutton.Enabled = false;

            if (user.delete_delegation == 1)
                m.Items.Add("Usuń");
        }


        void ContexMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e, int delegation_id)
        {

            if (e.ClickedItem.ToString() == "Pokaż")
            {
                var delegation = new EditDelegationForm(delegation_id);
                delegation.FormClosed += (s, args) => this.FillDataGrid();
                m.Hide();
            }
            else if (e.ClickedItem.ToString() == "Odśwież")
            {
                this.FillDataGrid();
                m.Hide();
            }
            else if (e.ClickedItem.ToString() == "Usuń")
            {
                var result = warning.Write("Czy napewno chcesz usunąć tę delegację?");
                m.Hide();
                if (result.ToString() == "Yes")
                {
                    var delegation = new Delegation().Delete(delegation_id);
                }
                this.FillDataGrid();
            }
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

        private void FilterButton_Click(object sender, EventArgs e)
        {
                var delegations = new Delegation().Filter(new {word = this.SearchTextBox.Text, to_date = this.DodateTimePicker.Value, from_date = this.OddateTimePicker.Value, user_id = 0 });
                this.dataGridView1.Rows.Clear();
                foreach (var delelegation in delegations)
                {   
                    this.dataGridView1.Rows.Add(delelegation.Id, delelegation.name, delelegation.surname,
                          delelegation.from_date, delelegation.to_date, delelegation.full_name, delelegation.target, delelegation.created_at, delelegation.updated_at);
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
            var editdelegation = new EditDelegationForm(delegation_id);
            editdelegation.FormClosed += (s, args) => this.FillDataGrid();
        }

        private void NewDelegationbutton_Click(object sender, EventArgs e)
        {
           new NewDelegationForm();
        }
    }
}
