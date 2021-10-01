
namespace Delegations
{
    partial class RoleAddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Zapiszbutton = new System.Windows.Forms.Button();
            this.RolecheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.RoleNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Zapiszbutton
            // 
            this.Zapiszbutton.Location = new System.Drawing.Point(223, 313);
            this.Zapiszbutton.Name = "Zapiszbutton";
            this.Zapiszbutton.Size = new System.Drawing.Size(75, 23);
            this.Zapiszbutton.TabIndex = 4;
            this.Zapiszbutton.Text = "Dodaj";
            this.Zapiszbutton.UseVisualStyleBackColor = true;
            this.Zapiszbutton.Click += new System.EventHandler(this.Zapiszbutton_Click);
            // 
            // RolecheckedListBox
            // 
            this.RolecheckedListBox.CheckOnClick = true;
            this.RolecheckedListBox.FormattingEnabled = true;
            this.RolecheckedListBox.Location = new System.Drawing.Point(12, 32);
            this.RolecheckedListBox.Name = "RolecheckedListBox";
            this.RolecheckedListBox.Size = new System.Drawing.Size(286, 274);
            this.RolecheckedListBox.TabIndex = 3;
            // 
            // RoleNameTextBox
            // 
            this.RoleNameTextBox.Location = new System.Drawing.Point(12, 313);
            this.RoleNameTextBox.Name = "RoleNameTextBox";
            this.RoleNameTextBox.Size = new System.Drawing.Size(205, 23);
            this.RoleNameTextBox.TabIndex = 6;
            // 
            // RoleAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 348);
            this.Controls.Add(this.RoleNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Zapiszbutton);
            this.Controls.Add(this.RolecheckedListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RoleAdd";
            this.ShowIcon = false;
            this.Text = "Nowa rola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Zapiszbutton;
        private System.Windows.Forms.CheckedListBox RolecheckedListBox;
        private System.Windows.Forms.TextBox RoleNameTextBox;
    }
}