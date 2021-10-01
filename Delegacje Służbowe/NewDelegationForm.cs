using System;
using System.Windows.Forms;

namespace Delegations
{
    public partial class NewDelegationForm : Form
    {
 
        public NewDelegationForm()
        {
            InitializeComponent();
            this.MdiParent = MainForm.ActiveForm;
            this.Show();
            this.Fill();
        }

        private void Fill()
        {
            var users = new Users().Get();
            foreach (var user in users)
            {
                this.checkedListBox1.Items.Add(new ComboboxItem(user.name + " " + user.surname, user.Id));
            }

            var lastmonth = DateTime.Today;
            var future = DateTime.Today.AddDays(1);
            OddateTimePicker.Value = Convert.ToDateTime(lastmonth);
            DodateTimePicker.Value = Convert.ToDateTime(future);
          
        }

       

        private Boolean ValidateForm()
        {

            if (String.IsNullOrEmpty(this.CeltextBox.Text))
            {
                new ErrorBox().Write("Uzupełnij cel podróży");
                return false;
            }
                
            else if (String.IsNullOrEmpty(this.MiejscowosctextBox.Text))
            {
                new ErrorBox().Write("Uzupełnij cel podróży");
                return false;
            }
               
            else if (String.IsNullOrEmpty(this.OddateTimePicker.Text))
            {
                new ErrorBox().Write("Wskaż datę początkową");
                return false;
            }
           
            else if (String.IsNullOrEmpty(this.DodateTimePicker.Text))
            {
                new ErrorBox().Write("Wskaż datę końcową");
                return false;
            }
               
            else if (checkedListBox1.CheckedItems.Count == 0)
            {
                new ErrorBox().Write("Nie zaznaczono żadnego użytkownika");
                return false;
            }

            return true;

        }



        private void DodajDelegajcjebutton_Click(object sender, EventArgs e)
        {
            
            if(ValidateForm())
            {
                DateTime from_date = DateTime.Parse(OddateTimePicker.Value.ToString());
                DateTime to_date = DateTime.Parse(OddateTimePicker.Value.ToString());

                bool addDelegation = false;

                foreach (var item in checkedListBox1.CheckedItems)
                {
                    DateTime localDate = DateTime.Now;
                    int year = DateTime.Now.Year;
                    DateTime firstDay = new DateTime(year, 1, 1);

                    var selecteduser = item as ComboboxItem;

                    var user = new Users().Find((int)selecteduser.Value);
                    var delegations = new Delegation().Filter(new { user_id = user.Id });

                    foreach (var delegation in delegations)
                    {
                        DateTime from_date_db = DateTime.Parse(delegation.from_date.ToString());
                        DateTime to_date_db = DateTime.Parse(delegation.to_date.ToString());

                        if (from_date_db >= from_date && from_date <= to_date_db || from_date_db >= to_date && to_date <= to_date_db)
                        {
                            new ErrorBox().Write($"Dla użytkownika {user.name} {user.surname} istnieje delegacja w tym okriesie!");
                            addDelegation = false;
                            break;
                        }
                        else
                        {
                            addDelegation = true;
                        }

                    }

                    if (addDelegation)
                    {
                        var row_id = new Delegation().Add(new
                        {
                            user_id = user.Id,
                            city = this.MiejscowosctextBox.Text,
                            from_date = this.OddateTimePicker.Value,
                            to_date = this.DodateTimePicker.Value,
                            department = user.department,
                            target = this.CeltextBox.Text,
                            created_at = localDate,

                        });

                        if (row_id > 1)
                            new InfoBox().Write("Dodano delegację");                      
                    }
                }
            }
        }
    }
}
