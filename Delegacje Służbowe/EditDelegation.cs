using System;
using System.Drawing;
using System.Windows.Forms;
using SqlKata.Compilers;
using SqlKata.Execution;


namespace Delegacje_Służbowe
{
    public partial class EditDelegation : Form
    {
        private readonly int  delegation_id;

        public EditDelegation(int delegation_id)
        {
            this.delegation_id = delegation_id;
            InitializeComponent();
            this.MdiParent = MainForm.ActiveForm;
            this.Show();
            this.Fill();
            
        }

        private void Fill()
        {

            var compiler = new SqlServerCompiler();
            var db = new QueryFactory(Program.conn.con, compiler);
            var delegation = db.Query("Delegations").Where("Id", this.delegation_id).FirstOrDefault();

            this.NewDelegationgroupBox.Text = $"Edycja delegacji numer {delegation_id}";
            this.CeltextBox.Text = delegation.target;
            this.MiejscowosctextBox.Text = delegation.city;
            DateTime oDate = DateTime.Parse(delegation.from_date.ToString());
            this.OddateTimePicker.Value = oDate;
            DateTime dDate = DateTime.Parse(delegation.to_date.ToString());
            this.DodateTimePicker.Value = dDate;



        }

        private void ZapiszDelegajcjebutton_Click(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            var compiler = new SqlServerCompiler();
            var db = new QueryFactory(Program.conn.con, compiler);
            var affected = db.Query("Delegations").Where("Id", this.delegation_id).Update(new
            {
                target = this.CeltextBox.Text,
                city = this.MiejscowosctextBox.Text,
                from_date = this.OddateTimePicker.Value,
                to_date = this.DodateTimePicker.Value,
                 
                updated_at = localDate,

            }); 

            if (affected == 1)
            {
                this.confirmLabel.Text = "Dane zostały zaktualizowane";
                this.confirmLabel.ForeColor = Color.Green;
            }

        }
    }
}
