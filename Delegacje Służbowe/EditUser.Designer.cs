
namespace Delegacje_Służbowe
{
    partial class EditUser
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusCheckBox = new System.Windows.Forms.CheckBox();
            this.rolaComboBox = new System.Windows.Forms.ComboBox();
            this.departamentComboBox = new System.Windows.Forms.ComboBox();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.nazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.imieTexBox = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.rolaLabel = new System.Windows.Forms.Label();
            this.departamentLabel = new System.Windows.Forms.Label();
            this.hasloLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.nazwiskoLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.saveUserButton = new System.Windows.Forms.Button();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.statusCheckBox);
            this.groupBox1.Controls.Add(this.rolaComboBox);
            this.groupBox1.Controls.Add(this.departamentComboBox);
            this.groupBox1.Controls.Add(this.changePasswordButton);
            this.groupBox1.Controls.Add(this.loginTextBox);
            this.groupBox1.Controls.Add(this.nazwiskoTextBox);
            this.groupBox1.Controls.Add(this.imieTexBox);
            this.groupBox1.Controls.Add(this.StatusLabel);
            this.groupBox1.Controls.Add(this.rolaLabel);
            this.groupBox1.Controls.Add(this.departamentLabel);
            this.groupBox1.Controls.Add(this.hasloLabel);
            this.groupBox1.Controls.Add(this.loginLabel);
            this.groupBox1.Controls.Add(this.nazwiskoLabel);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane użytkownika";
            // 
            // statusCheckBox
            // 
            this.statusCheckBox.AutoSize = true;
            this.statusCheckBox.Location = new System.Drawing.Point(117, 208);
            this.statusCheckBox.Name = "statusCheckBox";
            this.statusCheckBox.Size = new System.Drawing.Size(220, 19);
            this.statusCheckBox.TabIndex = 13;
            this.statusCheckBox.Text = "Konto użytkownika jest zablokowane";
            this.statusCheckBox.UseVisualStyleBackColor = true;
            // 
            // rolaComboBox
            // 
            this.rolaComboBox.FormattingEnabled = true;
            this.rolaComboBox.Location = new System.Drawing.Point(117, 179);
            this.rolaComboBox.Name = "rolaComboBox";
            this.rolaComboBox.Size = new System.Drawing.Size(204, 23);
            this.rolaComboBox.TabIndex = 12;
            // 
            // departamentComboBox
            // 
            this.departamentComboBox.FormattingEnabled = true;
            this.departamentComboBox.Location = new System.Drawing.Point(117, 150);
            this.departamentComboBox.Name = "departamentComboBox";
            this.departamentComboBox.Size = new System.Drawing.Size(204, 23);
            this.departamentComboBox.TabIndex = 11;
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(117, 121);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(95, 23);
            this.changePasswordButton.TabIndex = 10;
            this.changePasswordButton.Text = "Zmień hasło";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(117, 92);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(204, 23);
            this.loginTextBox.TabIndex = 9;
            // 
            // nazwiskoTextBox
            // 
            this.nazwiskoTextBox.Location = new System.Drawing.Point(117, 63);
            this.nazwiskoTextBox.Name = "nazwiskoTextBox";
            this.nazwiskoTextBox.Size = new System.Drawing.Size(204, 23);
            this.nazwiskoTextBox.TabIndex = 8;
            // 
            // imieTexBox
            // 
            this.imieTexBox.Location = new System.Drawing.Point(117, 34);
            this.imieTexBox.Name = "imieTexBox";
            this.imieTexBox.Size = new System.Drawing.Size(204, 23);
            this.imieTexBox.TabIndex = 7;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(6, 209);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(42, 15);
            this.StatusLabel.TabIndex = 6;
            this.StatusLabel.Text = "Status:";
            // 
            // rolaLabel
            // 
            this.rolaLabel.AutoSize = true;
            this.rolaLabel.Location = new System.Drawing.Point(6, 182);
            this.rolaLabel.Name = "rolaLabel";
            this.rolaLabel.Size = new System.Drawing.Size(33, 15);
            this.rolaLabel.TabIndex = 5;
            this.rolaLabel.Text = "Rola:";
            // 
            // departamentLabel
            // 
            this.departamentLabel.AutoSize = true;
            this.departamentLabel.Location = new System.Drawing.Point(6, 153);
            this.departamentLabel.Name = "departamentLabel";
            this.departamentLabel.Size = new System.Drawing.Size(79, 15);
            this.departamentLabel.TabIndex = 4;
            this.departamentLabel.Text = "Departament:";
            // 
            // hasloLabel
            // 
            this.hasloLabel.AutoSize = true;
            this.hasloLabel.Location = new System.Drawing.Point(6, 125);
            this.hasloLabel.Name = "hasloLabel";
            this.hasloLabel.Size = new System.Drawing.Size(40, 15);
            this.hasloLabel.TabIndex = 3;
            this.hasloLabel.Text = "Hasło:";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(6, 95);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(40, 15);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Login:";
            // 
            // nazwiskoLabel
            // 
            this.nazwiskoLabel.AutoSize = true;
            this.nazwiskoLabel.Location = new System.Drawing.Point(6, 66);
            this.nazwiskoLabel.Name = "nazwiskoLabel";
            this.nazwiskoLabel.Size = new System.Drawing.Size(60, 15);
            this.nazwiskoLabel.TabIndex = 1;
            this.nazwiskoLabel.Text = "Nazwisko:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 37);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(33, 15);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Imię:";
            // 
            // saveUserButton
            // 
            this.saveUserButton.Location = new System.Drawing.Point(294, 281);
            this.saveUserButton.Name = "saveUserButton";
            this.saveUserButton.Size = new System.Drawing.Size(75, 23);
            this.saveUserButton.TabIndex = 1;
            this.saveUserButton.Text = "Zapisz";
            this.saveUserButton.UseVisualStyleBackColor = true;
            this.saveUserButton.Click += new System.EventHandler(this.SaveUserButton_Click);
            // 
            // confirmLabel
            // 
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.Location = new System.Drawing.Point(18, 285);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(0, 15);
            this.confirmLabel.TabIndex = 2;
            // 
            // EditUser
            // 
            this.AcceptButton = this.saveUserButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 321);
            this.Controls.Add(this.confirmLabel);
            this.Controls.Add(this.saveUserButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditUser";
            this.ShowIcon = false;
            this.Text = "Edycja użytkownika";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label departamentLabel;
        private System.Windows.Forms.Label hasloLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label nazwiskoLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label rolaLabel;
        private System.Windows.Forms.CheckBox statusCheckBox;
        private System.Windows.Forms.ComboBox rolaComboBox;
        private System.Windows.Forms.ComboBox departamentComboBox;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox nazwiskoTextBox;
        private System.Windows.Forms.TextBox imieTexBox;
        public System.Windows.Forms.Button saveUserButton;
        private System.Windows.Forms.Label confirmLabel;
    }
}