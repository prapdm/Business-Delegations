﻿using System;
using System.Windows.Forms;
using SqlKata.Compilers;
using SqlKata.Execution;

namespace Delegacje_Służbowe
{
    public partial class RoleAdd : Form
    {

        private readonly Role roles;
        private readonly SqlServerCompiler compiler;
        private readonly QueryFactory db;

        public RoleAdd(Role roles)
        {
            this.compiler = new SqlServerCompiler();
            this.db = new QueryFactory(Program.conn.con, this.compiler);
            InitializeComponent();
            this.MdiParent = MainForm.ActiveForm;
            this.Show();
            label1.Text = $"Zaznacz uprawnienia dla nowej roli ";
            RolecheckedListBox.Items.Add("Dodawanie nowego użytkownika");
            RolecheckedListBox.Items.Add("Edytowanie użytkowników");
            RolecheckedListBox.Items.Add("Wyświetlanie użytkowników");
            RolecheckedListBox.Items.Add("Usuwanie użytkowników");
            RolecheckedListBox.Items.Add("Dodawanie departamentów");
            RolecheckedListBox.Items.Add("Usuwanie depeartamentów");
            RolecheckedListBox.Items.Add("Wyświetlanie depeartamentów");
            RolecheckedListBox.Items.Add("Wyświetlanie roli");
            RolecheckedListBox.Items.Add("Dodawanie roli");
            RolecheckedListBox.Items.Add("Modyfikowanie roli");
            RolecheckedListBox.Items.Add("Usuwanie roli");
            RolecheckedListBox.Items.Add("Dodawanie delegacji");
            RolecheckedListBox.Items.Add("Modyfikowanie delegacji");
            RolecheckedListBox.Items.Add("Usuwanie delegacji");
            this.roles = roles;
        }

        private void Zapiszbutton_Click(object sender, EventArgs e)
        {

            DateTime localDate = DateTime.Now;

            if (String.IsNullOrEmpty(this.RoleNameTextBox.Text))
                MessageBox.Show("Wpisz nazwę roli", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var row_id = db.Query("Roles").InsertGetId<int>(new
                {
                    role_name = this.RoleNameTextBox.Text,
                    add_new_user = (bool)RolecheckedListBox.GetItemChecked(0),
                    modify_user = (bool)RolecheckedListBox.GetItemChecked(1),
                    view_users = (bool)RolecheckedListBox.GetItemChecked(2),
                    delete_user = (bool)RolecheckedListBox.GetItemChecked(3),
                    add_departments = (bool)RolecheckedListBox.GetItemChecked(4),
                    del_departments = (bool)RolecheckedListBox.GetItemChecked(5),
                    view_departments = (bool)RolecheckedListBox.GetItemChecked(6),
                    add_roles = (bool)RolecheckedListBox.GetItemChecked(7),
                    modify_role = (bool)RolecheckedListBox.GetItemChecked(8),
                    view_roles = (bool)RolecheckedListBox.GetItemChecked(9),
                    del_roles = (bool)RolecheckedListBox.GetItemChecked(10),
                    add_delegation = (bool)RolecheckedListBox.GetItemChecked(11),
                    modify_delegation = (bool)RolecheckedListBox.GetItemChecked(12),
                    delete_delegation = (bool)RolecheckedListBox.GetItemChecked(13),
                    created_at = localDate,

                });

                if (row_id > 1)
                {
                    if (this.roles != null)
                        this.roles.Fill();
                    this.Close();
                }


            }
        }
    }
}
