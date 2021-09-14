using System;
using SqlKata.Compilers;
using SqlKata.Execution;
using System.Windows.Forms;
using System.Diagnostics;

namespace Delegacje_Służbowe
{


    public partial class Dzialy : Form
    {
        public Dzialy()
        {
            InitializeComponent();
            this.MdiParent = MainForm.ActiveForm;
            this.Show();
            this.Fill();
        }

        public void Fill()
        {
            var db = new QueryFactory(Program.conn.con, new SqlServerCompiler());
            var departments = db.Query("Departments").Get();
 
            foreach (var department in departments)
            {
                listBox1.Items.Add(department.full_name);
            }


        }

        private void Usunbutton1_Click(object sender, EventArgs e)
        {
            string curItem = listBox1.SelectedItem.ToString();
            var db = new QueryFactory(Program.conn.con, new SqlServerCompiler());
            var roles = db.Query("Departments").Where("full_name", curItem).Delete();

            listBox1.Items.Remove(curItem);

        }

        private void addDodaj_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(this.AddtextBox.Text))
            {
                DateTime localDate = DateTime.Now;
                Debug.WriteLine(this.AddtextBox.Text);
                var db = new QueryFactory(Program.conn.con, new SqlServerCompiler());
                var row_id = db.Query("Departments").InsertGetId<int>(new
                {
                    full_name = this.AddtextBox.Text,
                    created_at = localDate,
                });

                if (row_id > 1)
                {
                    listBox1.Items.Add(this.AddtextBox.Text);
                }

            }
            else
                MessageBox.Show("Wpisz nazwę działu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);



        }
    }
 
}

 
