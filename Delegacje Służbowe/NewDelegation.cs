using System;
using System.Windows.Forms;
using SqlKata.Compilers;
using SqlKata.Execution;

namespace Delegacje_Służbowe
{
    public partial class NewDelegation : Form
    {
        public NewDelegation()
        {
            InitializeComponent();
            this.MdiParent = MainForm.ActiveForm;
            this.Show();
            this.Fill();
        }

        private void Fill()
        {

            var compiler = new SqlServerCompiler();
            var db = new QueryFactory(Program.conn.con, compiler);
            var users = db.Query("Users").Where("Status",1).Get();


            foreach (var user in users)
            { 
                this.checkedListBox1.Items.Add(user.name + " " + user.surname);
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            string search = this.SearchTextBox.Text;
            var compiler = new SqlServerCompiler();
            var db = new QueryFactory(Program.conn.con, compiler);

            

            if (!String.IsNullOrEmpty(search))
            {
                var users = db.Query("Users").Where("Status", 1).Where(q =>
                                q.WhereLike("name", $"%{search}%").OrWhereLike("surname", $"%{search}%")
                            ).Get();
                this.checkedListBox1.Items.Clear();
                foreach (var user in users)
                {
                    this.checkedListBox1.Items.Add(user.name + " " + user.surname);
                }
            }
            else
            {
                var users = db.Query("Users").Where("Status", 1).Get();
                this.checkedListBox1.Items.Clear();
                foreach (var user in users)
                {
                    this.checkedListBox1.Items.Add(user.name + " " + user.surname);
                }
            }

        }

        private void DodajDelegajcjebutton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.CeltextBox.Text))
                MessageBox.Show("Uzupełnij cel podróży", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (String.IsNullOrEmpty(this.MiejscowosctextBox.Text))
                MessageBox.Show("Uzupełnij miejsce podróży", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (String.IsNullOrEmpty(this.OddateTimePicker.Text))
                MessageBox.Show("Wskaż datę początkową", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (String.IsNullOrEmpty(this.DodateTimePicker.Text))
                MessageBox.Show("Wskaż datę końcową", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (checkedListBox1.CheckedItems.Count == 0)
                MessageBox.Show("Nie zaznaczono żadnego użytkownika", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {

                var compiler = new SqlServerCompiler();
                var db = new QueryFactory(Program.conn.con, compiler);


                DateTime from_date = DateTime.Parse(OddateTimePicker.Value.ToString());
                DateTime to_date = DateTime.Parse(OddateTimePicker.Value.ToString());

                bool addDelegation = false;

                foreach (string name_surname in checkedListBox1.CheckedItems)
                {
                   
                    string[] split_name = name_surname.Split(' ');
                    DateTime localDate = DateTime.Now;

                    var user = db.Query("Users").Where("name", split_name[0]).Where("surname", split_name[1]).FirstOrDefault();
                    int user_id = (int)user.Id;
                    var delegations = db.Query("Delegations").Where("user_id", user_id).Get();


                    foreach (var delegation in delegations)
                    {
                        DateTime from_date_db = DateTime.Parse(delegation.from_date.ToString());
                        DateTime to_date_db = DateTime.Parse(delegation.to_date.ToString());

                        if (from_date_db >= from_date && from_date <= to_date_db || from_date_db >= to_date && to_date <= to_date_db)
                        {
                            MessageBox.Show($"Dla użytkownika {name_surname} istnieje delegacja w tym okriesie!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            addDelegation = false;
                            break;
                        }
                    

                    
                        else
                        {
                            addDelegation = true;
                        }

                    }

                    if(addDelegation)
                    {
                        var row_id = db.Query("Delegations").InsertGetId<int>(new
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
                        {
                            MessageBox.Show("Dodano delegację", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    

                }

            }

        }
    }
}
