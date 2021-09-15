
namespace Delegacje_Służbowe
{
    partial class DetailsRole
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
            this.RolecheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.Zapiszbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RolecheckedListBox
            // 
            this.RolecheckedListBox.CheckOnClick = true;
            this.RolecheckedListBox.FormattingEnabled = true;
            this.RolecheckedListBox.Location = new System.Drawing.Point(12, 30);
            this.RolecheckedListBox.Name = "RolecheckedListBox";
            this.RolecheckedListBox.Size = new System.Drawing.Size(286, 274);
            this.RolecheckedListBox.TabIndex = 0;
            // 
            // Zapiszbutton
            // 
            this.Zapiszbutton.Location = new System.Drawing.Point(223, 310);
            this.Zapiszbutton.Name = "Zapiszbutton";
            this.Zapiszbutton.Size = new System.Drawing.Size(75, 23);
            this.Zapiszbutton.TabIndex = 1;
            this.Zapiszbutton.Text = "Zapisz";
            this.Zapiszbutton.UseVisualStyleBackColor = true;
            this.Zapiszbutton.Click += new System.EventHandler(this.Zapiszbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // DetailsRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 344);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Zapiszbutton);
            this.Controls.Add(this.RolecheckedListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DetailsRole";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Text = "Edytuj role";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox RolecheckedListBox;
        public System.Windows.Forms.Button Zapiszbutton;
        private System.Windows.Forms.Label label1;
    }
}