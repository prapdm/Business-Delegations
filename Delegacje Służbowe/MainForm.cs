using System;
using System.Windows.Forms;

namespace Delegations
{
    public partial class MainForm : Form
    {
        private readonly int loged_user;
        public MainForm(int loged_user_id)
        {
            InitializeComponent();
            this.Show();
            this.loged_user = loged_user_id;
            ChekMenuAccess();
        }

        private void ChekMenuAccess()
        {
            var user = new Users().Find(loged_user);

            if (user != null)
            {
                foreach (ToolStripMenuItem item in this.MainMenuStrip.Items)
                {
                    foreach (ToolStripItem subitem in item.DropDownItems)
                    {
                        if (subitem.Name.Contains("newDelegationStripMenuItem"))
                            if (user.add_delegation == 0) subitem.Enabled = false;

                        if (subitem.Name.Contains("openDelegationsStripMenuItem"))
                            if (user.view_delegation == 0) subitem.Enabled = false;

                        if (subitem.Name.Contains("nowyPracownikToolStripMenuItem"))
                            if (user.add_new_user == 0) subitem.Enabled = false;

                        if (subitem.Name.Contains("listaPracownikówToolStripMenuItem"))
                            if (user.view_users == 0) subitem.Enabled = false;

                        if (subitem.Name.Contains("działyToolStripMenuItem"))
                            if (user.view_departments == 0) subitem.Enabled = false;

                        if (subitem.Name.Contains("roleToolStripMenuItem"))
                            if (user.view_roles == 0) subitem.Enabled = false;

                    }
                }
            }
            else this.Close();
        }


        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewDelegationForm();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListaPracownikówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UsersListForm(loged_user);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Timer timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Enabled = true;
            timer1.Start(); 
        }

        private void Timer1_Tick(object Sender, EventArgs e)
        {          
            toolStripStatusLabel1.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }

        private void PasswordChangeStripMenuItem_Click(object sender, EventArgs e)
        {
            new ChangePasswordForm(loged_user);
        }

        private void NowyPracownikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewUserForm();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new AboutBox();
        }

        private void DziałyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DepartmentsForm(loged_user);
        }

        private void RoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RoleForm(loged_user);
        }

        private void OpenDelegationsStripMenuItem_Click(object sender, EventArgs e)
        {
            new ShowDelegationsForm(loged_user);
        }


    }
}
