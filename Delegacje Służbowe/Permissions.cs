using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using SqlKata.Compilers;
using SqlKata.Execution;


namespace Delegacje_Służbowe
{
    class Permissions
    {

    
        private readonly int user_id;
        private readonly SqlServerCompiler compiler;
        private readonly QueryFactory db;
        private readonly dynamic user;

        public Permissions(int user_id)
        {
            this.user_id = user_id;
             
            this.compiler =  new SqlServerCompiler();
            this.db = new QueryFactory(Program.conn.con, this.compiler);
            this.user = db.Query("Users").Join("Roles", "Roles.Id", "Users.role").Where("Users.Id", user_id).Where("status", 1).FirstOrDefault();

        }

        public void CheckUserListPermisions(UsersList usersList)
        {
            
            if (user != null)
            {
                if (user.add_new_user == 0) usersList.newUserbutton.Enabled = false;

            }

        }

        public void CheckDelegationPermisions(ShowDelegations showDelegations)
        {
       
            if (user != null)
            {
                if (user.add_delegation == 0) showDelegations.newDelegationbutton.Enabled = false;

            }

        }

        
       public void CheckDetailsRolesPermisions(DetailsRole detailsRole)
        {
           
            if (user != null)
            {
                
                if (user.modify_role == 0) detailsRole.Zapiszbutton.Enabled = false;
              

            }

        }
        public void CheckRolesPermisions(Role role)
        {
          
            if (user != null)
            {
                if (user.add_roles == 0) role.addDodaj.Enabled = false;
                if (user.modify_role == 0) role.Edytujbutton.Enabled = false;
                if (user.del_roles == 0) role.Usunbutton.Enabled = false;

            }

        }


        public void CheckDzialyPermisions(Dzialy dzialy)
        {
           
            if (user != null)
            {
                if (user.add_departments  == 0) dzialy.addDodaj.Enabled = false;
                if (user.del_departments == 0) dzialy.Usunbutton1.Enabled = false;

            }

        }

        public void CheckEditDelegationPermisions(EditDelegation editDelegation)
        {
           
            if (user != null)
            {
                if (user.modify_delegation == 0) editDelegation.ZapiszDelegajcjebutton.Enabled = false;

            }

        }

        public void CheckEditUserPermisions(EditUser editUser)
        {
          
            if (user != null)
            {
                if (user.modify_user == 0) editUser.saveUserButton.Enabled = false;

            }

        }


        public void CheckMainMenu(MainForm mainForm)
        {
       
            
            if (user != null)
            {
                     
                    foreach (ToolStripMenuItem item in mainForm.MainMenuStrip.Items)
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
        }
    }
}
