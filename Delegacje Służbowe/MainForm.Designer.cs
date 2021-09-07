
namespace Delegacje_Służbowe
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDelegationStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDelegationsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nowyPracownikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaPracownikówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uprawnieniaStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordChangeStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(853, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDelegationStripMenuItem,
            this.openDelegationsStripMenuItem,
            this.toolStripSeparator1,
            this.nowyPracownikToolStripMenuItem,
            this.listaPracownikówToolStripMenuItem,
            this.toolStripSeparator6,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.fileToolStripMenuItem.Text = "&Home";
            // 
            // newDelegationStripMenuItem
            // 
            this.newDelegationStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newDelegationStripMenuItem.Image")));
            this.newDelegationStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newDelegationStripMenuItem.Name = "newDelegationStripMenuItem";
            this.newDelegationStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.newDelegationStripMenuItem.Text = "&Nowa delegacja";
            this.newDelegationStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openDelegationsStripMenuItem
            // 
            this.openDelegationsStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openDelegationsStripMenuItem.Image")));
            this.openDelegationsStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openDelegationsStripMenuItem.Name = "openDelegationsStripMenuItem";
            this.openDelegationsStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.openDelegationsStripMenuItem.Text = "&Rejestr delegacji";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // nowyPracownikToolStripMenuItem
            // 
            this.nowyPracownikToolStripMenuItem.Name = "nowyPracownikToolStripMenuItem";
            this.nowyPracownikToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.nowyPracownikToolStripMenuItem.Text = "Nowy pracownik";
            // 
            // listaPracownikówToolStripMenuItem
            // 
            this.listaPracownikówToolStripMenuItem.Name = "listaPracownikówToolStripMenuItem";
            this.listaPracownikówToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.listaPracownikówToolStripMenuItem.Text = "Lista pracowników";
            this.listaPracownikówToolStripMenuItem.Click += new System.EventHandler(this.listaPracownikówToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(169, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uprawnieniaStripMenuItem,
            this.passwordChangeStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.toolsToolStripMenuItem.Text = "&Konfiguracja";
            // 
            // uprawnieniaStripMenuItem
            // 
            this.uprawnieniaStripMenuItem.Name = "uprawnieniaStripMenuItem";
            this.uprawnieniaStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.uprawnieniaStripMenuItem.Text = "&Uprawnienia";
            // 
            // passwordChangeStripMenuItem
            // 
            this.passwordChangeStripMenuItem.Name = "passwordChangeStripMenuItem";
            this.passwordChangeStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.passwordChangeStripMenuItem.Text = "&Zmiana hasła";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.helpToolStripMenuItem.Text = "&Pomoc";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.aboutToolStripMenuItem.Text = "&O programie";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 406);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(853, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(807, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 428);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Delegacje służbowe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDelegationStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDelegationsStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uprawnieniaStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordChangeStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyPracownikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaPracownikówToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
    }
}