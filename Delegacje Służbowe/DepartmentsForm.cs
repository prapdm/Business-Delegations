using System;
using System.Windows.Forms;


namespace Delegations
{

    public partial class DepartmentsForm : Form
    {
        private readonly int user_id;
        public DepartmentsForm(int user_id)
        {
            this.user_id = user_id;
            InitializeComponent();
            this.MdiParent = MainForm.ActiveForm;
            this.Show();
            this.Fill();
            
        }

        private void Fill()
        {
            listBox1.Items.Clear();
            var departments = new Departaments().Get();
            foreach (var department in departments)
            {
                this.listBox1.Items.Add(new ComboboxItem(department.full_name, department.Id));
            }
            CheckFormAcces();
        }

        private void CheckFormAcces()
        {
            var user = new Users().Find(user_id);
            if (user.add_departments == 0) addDodaj.Enabled = false;
            if (user.del_departments == 0) Usunbutton1.Enabled = false;
        }

        private void Usunbutton1_Click(object sender, EventArgs e)
        {
            var selectedDepartment = listBox1.SelectedItem as ComboboxItem;

            var affected = new Departaments().Delete((int)selectedDepartment.Value);
            if (affected > 0)
                this.Fill();

        }

        private void AddDodaj_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(this.AddtextBox.Text))
            {
                DateTime localDate = DateTime.Now;

                var row_id = new Departaments().Add(new
                {
                    full_name = this.AddtextBox.Text,
                    created_at = localDate,
                });

                if (row_id > 1)
                    this.Fill();

            }
            else
                new ErrorBox().Write("Wpisz nazwę działu");



        }
    }
 
}

 
