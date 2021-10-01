
namespace Delegations
{
    partial class EditDelegationForm
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
            this.NewDelegationgroupBox = new System.Windows.Forms.GroupBox();
            this.ZapiszDelegajcjebutton = new System.Windows.Forms.Button();
            this.DodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.OddateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MiejscowosctextBox = new System.Windows.Forms.TextBox();
            this.CeltextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.NewDelegationgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewDelegationgroupBox
            // 
            this.NewDelegationgroupBox.Controls.Add(this.confirmLabel);
            this.NewDelegationgroupBox.Controls.Add(this.ZapiszDelegajcjebutton);
            this.NewDelegationgroupBox.Controls.Add(this.DodateTimePicker);
            this.NewDelegationgroupBox.Controls.Add(this.OddateTimePicker);
            this.NewDelegationgroupBox.Controls.Add(this.MiejscowosctextBox);
            this.NewDelegationgroupBox.Controls.Add(this.CeltextBox);
            this.NewDelegationgroupBox.Controls.Add(this.label4);
            this.NewDelegationgroupBox.Controls.Add(this.label3);
            this.NewDelegationgroupBox.Controls.Add(this.label2);
            this.NewDelegationgroupBox.Controls.Add(this.label1);
            this.NewDelegationgroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewDelegationgroupBox.Location = new System.Drawing.Point(0, 0);
            this.NewDelegationgroupBox.Name = "NewDelegationgroupBox";
            this.NewDelegationgroupBox.Size = new System.Drawing.Size(383, 206);
            this.NewDelegationgroupBox.TabIndex = 1;
            this.NewDelegationgroupBox.TabStop = false;
            // 
            // ZapiszDelegajcjebutton
            // 
            this.ZapiszDelegajcjebutton.Location = new System.Drawing.Point(252, 164);
            this.ZapiszDelegajcjebutton.Name = "ZapiszDelegajcjebutton";
            this.ZapiszDelegajcjebutton.Size = new System.Drawing.Size(111, 23);
            this.ZapiszDelegajcjebutton.TabIndex = 1;
            this.ZapiszDelegajcjebutton.Text = "Zapisz";
            this.ZapiszDelegajcjebutton.UseVisualStyleBackColor = true;
            this.ZapiszDelegajcjebutton.Click += new System.EventHandler(this.ZapiszDelegajcjebutton_Click);
            // 
            // DodateTimePicker
            // 
            this.DodateTimePicker.CustomFormat = "dd-MM-yyyy HH:mm";
            this.DodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DodateTimePicker.Location = new System.Drawing.Point(133, 119);
            this.DodateTimePicker.Name = "DodateTimePicker";
            this.DodateTimePicker.Size = new System.Drawing.Size(230, 23);
            this.DodateTimePicker.TabIndex = 7;
            // 
            // OddateTimePicker
            // 
            this.OddateTimePicker.CustomFormat = "dd-MM-yyyy HH:mm";
            this.OddateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.OddateTimePicker.Location = new System.Drawing.Point(133, 90);
            this.OddateTimePicker.Name = "OddateTimePicker";
            this.OddateTimePicker.Size = new System.Drawing.Size(230, 23);
            this.OddateTimePicker.TabIndex = 6;
            // 
            // MiejscowosctextBox
            // 
            this.MiejscowosctextBox.Location = new System.Drawing.Point(133, 61);
            this.MiejscowosctextBox.Name = "MiejscowosctextBox";
            this.MiejscowosctextBox.Size = new System.Drawing.Size(230, 23);
            this.MiejscowosctextBox.TabIndex = 5;
            // 
            // CeltextBox
            // 
            this.CeltextBox.Location = new System.Drawing.Point(133, 32);
            this.CeltextBox.Name = "CeltextBox";
            this.CeltextBox.Size = new System.Drawing.Size(230, 23);
            this.CeltextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data przyjazdu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data wyjazdu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Miejscowość:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cel podróży:";
            // 
            // confirmLabel
            // 
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.Location = new System.Drawing.Point(12, 168);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(0, 15);
            this.confirmLabel.TabIndex = 8;
            // 
            // EditDelegation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 206);
            this.Controls.Add(this.NewDelegationgroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditDelegation";
            this.ShowIcon = false;
            this.Text = "Edycja delegacji";
            this.NewDelegationgroupBox.ResumeLayout(false);
            this.NewDelegationgroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NewDelegationgroupBox;
        public System.Windows.Forms.Button ZapiszDelegajcjebutton;
        private System.Windows.Forms.DateTimePicker DodateTimePicker;
        private System.Windows.Forms.DateTimePicker OddateTimePicker;
        private System.Windows.Forms.TextBox MiejscowosctextBox;
        private System.Windows.Forms.TextBox CeltextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label confirmLabel;
    }
}