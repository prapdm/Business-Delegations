
namespace Delegations
{
    partial class ChangePasswordForm
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
            this.passwordChangegroupBox = new System.Windows.Forms.GroupBox();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordtextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordlabel = new System.Windows.Forms.Label();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.saveNewPasswordButton = new System.Windows.Forms.Button();
            this.confirmLabelPassword = new System.Windows.Forms.Label();
            this.passwordChangegroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordChangegroupBox
            // 
            this.passwordChangegroupBox.Controls.Add(this.confirmPasswordTextBox);
            this.passwordChangegroupBox.Controls.Add(this.newPasswordtextBox);
            this.passwordChangegroupBox.Controls.Add(this.confirmPasswordlabel);
            this.passwordChangegroupBox.Controls.Add(this.newPasswordLabel);
            this.passwordChangegroupBox.Location = new System.Drawing.Point(12, 12);
            this.passwordChangegroupBox.Name = "passwordChangegroupBox";
            this.passwordChangegroupBox.Size = new System.Drawing.Size(347, 124);
            this.passwordChangegroupBox.TabIndex = 0;
            this.passwordChangegroupBox.TabStop = false;
            this.passwordChangegroupBox.Text = "Nowe hasło";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(145, 78);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '*';
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(182, 23);
            this.confirmPasswordTextBox.TabIndex = 4;
            // 
            // newPasswordtextBox
            // 
            this.newPasswordtextBox.Location = new System.Drawing.Point(145, 43);
            this.newPasswordtextBox.Name = "newPasswordtextBox";
            this.newPasswordtextBox.PasswordChar = '*';
            this.newPasswordtextBox.Size = new System.Drawing.Size(182, 23);
            this.newPasswordtextBox.TabIndex = 3;
            // 
            // confirmPasswordlabel
            // 
            this.confirmPasswordlabel.AutoSize = true;
            this.confirmPasswordlabel.Location = new System.Drawing.Point(6, 81);
            this.confirmPasswordlabel.Name = "confirmPasswordlabel";
            this.confirmPasswordlabel.Size = new System.Drawing.Size(125, 15);
            this.confirmPasswordlabel.TabIndex = 1;
            this.confirmPasswordlabel.Text = "Potwierdź nowe hasło:";
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Location = new System.Drawing.Point(6, 46);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(72, 15);
            this.newPasswordLabel.TabIndex = 0;
            this.newPasswordLabel.Text = "Nowe hasło:";
            // 
            // saveNewPasswordButton
            // 
            this.saveNewPasswordButton.Location = new System.Drawing.Point(265, 142);
            this.saveNewPasswordButton.Name = "saveNewPasswordButton";
            this.saveNewPasswordButton.Size = new System.Drawing.Size(94, 23);
            this.saveNewPasswordButton.TabIndex = 2;
            this.saveNewPasswordButton.Text = "Zapisz";
            this.saveNewPasswordButton.UseVisualStyleBackColor = true;
            this.saveNewPasswordButton.Click += new System.EventHandler(this.SaveNewPasswordButton_Click);
            // 
            // confirmLabelPassword
            // 
            this.confirmLabelPassword.AutoSize = true;
            this.confirmLabelPassword.Location = new System.Drawing.Point(18, 146);
            this.confirmLabelPassword.Name = "confirmLabelPassword";
            this.confirmLabelPassword.Size = new System.Drawing.Size(0, 15);
            this.confirmLabelPassword.TabIndex = 3;
            // 
            // ChangePassword
            // 
            this.AcceptButton = this.saveNewPasswordButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 174);
            this.Controls.Add(this.confirmLabelPassword);
            this.Controls.Add(this.saveNewPasswordButton);
            this.Controls.Add(this.passwordChangegroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChangePassword";
            this.ShowIcon = false;
            this.Text = "Zmiana hasła";
            this.passwordChangegroupBox.ResumeLayout(false);
            this.passwordChangegroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox passwordChangegroupBox;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.TextBox newPasswordtextBox;
        private System.Windows.Forms.Label confirmPasswordlabel;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Button saveNewPasswordButton;
        private System.Windows.Forms.Label confirmLabelPassword;
    }
}