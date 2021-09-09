using System;
using System.Windows.Forms;

namespace Delegacje_Służbowe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        ~MainForm()
        {
            Program.conn.Dispose();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.conn.Dispose();
            this.Close();
        }

        private void ListaPracownikówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersList userslist= new UsersList();
            userslist.MdiParent = this;
            userslist.Show();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;//1 seconds
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Enabled = true;
            timer1.Start();

            
        }

        private void Timer1_Tick(object Sender, EventArgs e)
        {
            // Set the caption to the current time.  
           
            toolStripStatusLabel1.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }

        private void passwordChangeStripMenuItem_Click(object sender, EventArgs e)
        {
            new ChangePassword(Form1.loged_user);
        }

        private void nowyPracownikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewUser();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new AboutBox1();
        }
    }
}
