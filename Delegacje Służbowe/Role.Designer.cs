
namespace Delegacje_Służbowe
{
    partial class Role
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addDodaj = new System.Windows.Forms.Button();
            this.Usunbutton = new System.Windows.Forms.Button();
            this.Rolelabel = new System.Windows.Forms.Label();
            this.RolelistBox = new System.Windows.Forms.ListBox();
            this.Edytujbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addDodaj
            // 
            this.addDodaj.Location = new System.Drawing.Point(12, 217);
            this.addDodaj.Name = "addDodaj";
            this.addDodaj.Size = new System.Drawing.Size(78, 23);
            this.addDodaj.TabIndex = 10;
            this.addDodaj.Text = "Dodaj";
            this.addDodaj.UseVisualStyleBackColor = true;
            this.addDodaj.Click += new System.EventHandler(this.AddDodaj_Click);
            // 
            // Usunbutton
            // 
            this.Usunbutton.Location = new System.Drawing.Point(180, 217);
            this.Usunbutton.Name = "Usunbutton";
            this.Usunbutton.Size = new System.Drawing.Size(76, 23);
            this.Usunbutton.TabIndex = 9;
            this.Usunbutton.Text = "Usuń";
            this.Usunbutton.UseVisualStyleBackColor = true;
            this.Usunbutton.Click += new System.EventHandler(this.Usunbutton_Click);
            // 
            // Rolelabel
            // 
            this.Rolelabel.AutoSize = true;
            this.Rolelabel.Location = new System.Drawing.Point(12, 9);
            this.Rolelabel.Name = "Rolelabel";
            this.Rolelabel.Size = new System.Drawing.Size(33, 15);
            this.Rolelabel.TabIndex = 8;
            this.Rolelabel.Text = "Role:";
            // 
            // RolelistBox
            // 
            this.RolelistBox.FormattingEnabled = true;
            this.RolelistBox.ItemHeight = 15;
            this.RolelistBox.Location = new System.Drawing.Point(12, 27);
            this.RolelistBox.Name = "RolelistBox";
            this.RolelistBox.Size = new System.Drawing.Size(244, 184);
            this.RolelistBox.TabIndex = 7;
            this.RolelistBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RolelistBox_MouseDoubleClick);
            // 
            // Edytujbutton
            // 
            this.Edytujbutton.Location = new System.Drawing.Point(96, 217);
            this.Edytujbutton.Name = "Edytujbutton";
            this.Edytujbutton.Size = new System.Drawing.Size(78, 23);
            this.Edytujbutton.TabIndex = 11;
            this.Edytujbutton.Text = "Edytuj";
            this.Edytujbutton.UseVisualStyleBackColor = true;
            this.Edytujbutton.Click += new System.EventHandler(this.Edytujbutton_Click);
            // 
            // Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 247);
            this.Controls.Add(this.Edytujbutton);
            this.Controls.Add(this.addDodaj);
            this.Controls.Add(this.Usunbutton);
            this.Controls.Add(this.Rolelabel);
            this.Controls.Add(this.RolelistBox);
            this.Name = "Role";
            this.ShowIcon = false;
            this.Text = "Role";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button addDodaj;
        public System.Windows.Forms.Button Usunbutton;
        private System.Windows.Forms.Label Rolelabel;
        private System.Windows.Forms.ListBox RolelistBox;
        public System.Windows.Forms.Button Edytujbutton;
    }
}