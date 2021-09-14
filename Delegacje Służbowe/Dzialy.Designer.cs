
namespace Delegacje_Służbowe
{
    partial class Dzialy
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Dzialylabel1 = new System.Windows.Forms.Label();
            this.Usunbutton1 = new System.Windows.Forms.Button();
            this.addDodaj = new System.Windows.Forms.Button();
            this.AddtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(185, 184);
            this.listBox1.TabIndex = 0;
            // 
            // Dzialylabel1
            // 
            this.Dzialylabel1.AutoSize = true;
            this.Dzialylabel1.Location = new System.Drawing.Point(12, 9);
            this.Dzialylabel1.Name = "Dzialylabel1";
            this.Dzialylabel1.Size = new System.Drawing.Size(41, 15);
            this.Dzialylabel1.TabIndex = 4;
            this.Dzialylabel1.Text = "Działy:";
            // 
            // Usunbutton1
            // 
            this.Usunbutton1.Location = new System.Drawing.Point(108, 247);
            this.Usunbutton1.Name = "Usunbutton1";
            this.Usunbutton1.Size = new System.Drawing.Size(89, 23);
            this.Usunbutton1.TabIndex = 5;
            this.Usunbutton1.Text = "Usuń";
            this.Usunbutton1.UseVisualStyleBackColor = true;
            this.Usunbutton1.Click += new System.EventHandler(this.Usunbutton1_Click);
            // 
            // addDodaj
            // 
            this.addDodaj.Location = new System.Drawing.Point(12, 247);
            this.addDodaj.Name = "addDodaj";
            this.addDodaj.Size = new System.Drawing.Size(90, 23);
            this.addDodaj.TabIndex = 6;
            this.addDodaj.Text = "Dodaj";
            this.addDodaj.UseVisualStyleBackColor = true;
            this.addDodaj.Click += new System.EventHandler(this.addDodaj_Click);
            // 
            // AddtextBox
            // 
            this.AddtextBox.Location = new System.Drawing.Point(12, 218);
            this.AddtextBox.Name = "AddtextBox";
            this.AddtextBox.Size = new System.Drawing.Size(185, 23);
            this.AddtextBox.TabIndex = 7;
            // 
            // Dzialy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 287);
            this.Controls.Add(this.AddtextBox);
            this.Controls.Add(this.addDodaj);
            this.Controls.Add(this.Usunbutton1);
            this.Controls.Add(this.Dzialylabel1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Dzialy";
            this.ShowIcon = false;
            this.Text = "Działy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label Dzialylabel1;
        private System.Windows.Forms.Button Usunbutton1;
        private System.Windows.Forms.Button addDodaj;
        private System.Windows.Forms.TextBox AddtextBox;
    }
}