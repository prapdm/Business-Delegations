using System;
using System.Drawing;
using System.Windows.Forms;
using Delegations;
using SqlKata.Compilers;
using SqlKata.Execution;


namespace Delegations
{
    public partial class EditDelegationForm : Form
    {
        private readonly int delegation_id;

        public EditDelegationForm(int delegation_id)
        {
            this.delegation_id = delegation_id;
            InitializeComponent();
            this.MdiParent = MainForm.ActiveForm;
            this.Show();
            this.Fill();
        }

        private void Fill()
        {
            var delegation = new Delegation().Find(delegation_id);

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
            var affected = new Delegation().Update(new
            {
                target = this.CeltextBox.Text,
                city = this.MiejscowosctextBox.Text,
                from_date = this.OddateTimePicker.Value,
                to_date = this.DodateTimePicker.Value,
                updated_at = localDate,

            }, delegation_id); 

            if (affected == 1)
            {
                this.confirmLabel.Text = "Dane zostały zaktualizowane";
                this.confirmLabel.ForeColor = Color.Green;
            }

        }
    }
}
