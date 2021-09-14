
namespace Delegacje_Służbowe
{
    partial class ShowDelegations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowDelegations));
            this.OperationsgroupBox = new System.Windows.Forms.GroupBox();
            this.newUserbutton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.target = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.OddateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Dolabel = new System.Windows.Forms.Label();
            this.Odlabel = new System.Windows.Forms.Label();
            this.FiltrLabel = new System.Windows.Forms.Label();
            this.FilterButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.OperationsgroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OperationsgroupBox
            // 
            this.OperationsgroupBox.Controls.Add(this.newUserbutton);
            this.OperationsgroupBox.Controls.Add(this.exportButton);
            this.OperationsgroupBox.Controls.Add(this.printButton);
            this.OperationsgroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.OperationsgroupBox.Location = new System.Drawing.Point(899, 0);
            this.OperationsgroupBox.Name = "OperationsgroupBox";
            this.OperationsgroupBox.Size = new System.Drawing.Size(231, 647);
            this.OperationsgroupBox.TabIndex = 5;
            this.OperationsgroupBox.TabStop = false;
            this.OperationsgroupBox.Text = "Operacje";
            // 
            // newUserbutton
            // 
            this.newUserbutton.Location = new System.Drawing.Point(18, 37);
            this.newUserbutton.Name = "newUserbutton";
            this.newUserbutton.Size = new System.Drawing.Size(201, 39);
            this.newUserbutton.TabIndex = 4;
            this.newUserbutton.Text = "Nowa delegacja";
            this.newUserbutton.UseVisualStyleBackColor = true;
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(18, 127);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(201, 39);
            this.exportButton.TabIndex = 1;
            this.exportButton.Text = "Exportuj do Excel";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(18, 82);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(201, 39);
            this.printButton.TabIndex = 0;
            this.printButton.Text = "Exportuj do PDF";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(899, 647);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.surname,
            this.from_date,
            this.to_date,
            this.department,
            this.target,
            this.created_at,
            this.updated_at});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(893, 601);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_MouseClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 30;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Imię";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // surname
            // 
            this.surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surname.DataPropertyName = "surname";
            this.surname.HeaderText = "Nazwisko";
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            // 
            // from_date
            // 
            this.from_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.from_date.DataPropertyName = "from_date";
            this.from_date.HeaderText = "Od";
            this.from_date.Name = "from_date";
            this.from_date.ReadOnly = true;
            // 
            // to_date
            // 
            this.to_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.to_date.DataPropertyName = "to_date";
            this.to_date.HeaderText = "Do";
            this.to_date.Name = "to_date";
            this.to_date.ReadOnly = true;
            // 
            // department
            // 
            this.department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.department.DataPropertyName = "department";
            this.department.HeaderText = "Departament";
            this.department.Name = "department";
            this.department.ReadOnly = true;
            this.department.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // target
            // 
            this.target.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.target.DataPropertyName = "target";
            this.target.HeaderText = "Cel";
            this.target.Name = "target";
            this.target.ReadOnly = true;
            // 
            // created_at
            // 
            this.created_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.created_at.DataPropertyName = "created_at";
            this.created_at.HeaderText = "Utworzono";
            this.created_at.Name = "created_at";
            this.created_at.ReadOnly = true;
            // 
            // updated_at
            // 
            this.updated_at.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.updated_at.DataPropertyName = "updated_at";
            this.updated_at.HeaderText = "Zaktualizowano";
            this.updated_at.Name = "updated_at";
            this.updated_at.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DodateTimePicker);
            this.panel1.Controls.Add(this.OddateTimePicker);
            this.panel1.Controls.Add(this.Dolabel);
            this.panel1.Controls.Add(this.Odlabel);
            this.panel1.Controls.Add(this.FiltrLabel);
            this.panel1.Controls.Add(this.FilterButton);
            this.panel1.Controls.Add(this.SearchTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 610);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 34);
            this.panel1.TabIndex = 2;
            // 
            // DodateTimePicker
            // 
            this.DodateTimePicker.CustomFormat = "dd-MM-yyyy HH:mm";
            this.DodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DodateTimePicker.Location = new System.Drawing.Point(507, 6);
            this.DodateTimePicker.Name = "DodateTimePicker";
            this.DodateTimePicker.Size = new System.Drawing.Size(126, 23);
            this.DodateTimePicker.TabIndex = 11;
            this.DodateTimePicker.Value = new System.DateTime(2021, 10, 14, 0, 0, 0, 0);
            // 
            // OddateTimePicker
            // 
            this.OddateTimePicker.CustomFormat = "dd-MM-yyyy HH:mm";
            this.OddateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.OddateTimePicker.Location = new System.Drawing.Point(344, 6);
            this.OddateTimePicker.Name = "OddateTimePicker";
            this.OddateTimePicker.Size = new System.Drawing.Size(126, 23);
            this.OddateTimePicker.TabIndex = 10;
            // 
            // Dolabel
            // 
            this.Dolabel.AutoSize = true;
            this.Dolabel.Location = new System.Drawing.Point(476, 9);
            this.Dolabel.Name = "Dolabel";
            this.Dolabel.Size = new System.Drawing.Size(25, 15);
            this.Dolabel.TabIndex = 9;
            this.Dolabel.Text = "Do:";
            // 
            // Odlabel
            // 
            this.Odlabel.AutoSize = true;
            this.Odlabel.Location = new System.Drawing.Point(312, 9);
            this.Odlabel.Name = "Odlabel";
            this.Odlabel.Size = new System.Drawing.Size(26, 15);
            this.Odlabel.TabIndex = 8;
            this.Odlabel.Text = "Od:";
            // 
            // FiltrLabel
            // 
            this.FiltrLabel.AutoSize = true;
            this.FiltrLabel.Location = new System.Drawing.Point(9, 9);
            this.FiltrLabel.Name = "FiltrLabel";
            this.FiltrLabel.Size = new System.Drawing.Size(30, 15);
            this.FiltrLabel.TabIndex = 6;
            this.FiltrLabel.Text = "Filtr:";
            // 
            // FilterButton
            // 
            this.FilterButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.FilterButton.FlatAppearance.BorderSize = 0;
            this.FilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterButton.Image = ((System.Drawing.Image)(resources.GetObject("FilterButton.Image")));
            this.FilterButton.Location = new System.Drawing.Point(661, 1);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(31, 30);
            this.FilterButton.TabIndex = 5;
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(61, 6);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(222, 23);
            this.SearchTextBox.TabIndex = 3;
            // 
            // ShowDelegations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 647);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.OperationsgroupBox);
            this.Name = "ShowDelegations";
            this.ShowIcon = false;
            this.Text = "Rejestr delegacji";
            this.OperationsgroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox OperationsgroupBox;
        private System.Windows.Forms.Button newUserbutton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label FiltrLabel;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn from_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn to_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn target;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_at;
        private System.Windows.Forms.Label Dolabel;
        private System.Windows.Forms.Label Odlabel;
        private System.Windows.Forms.DateTimePicker DodateTimePicker;
        private System.Windows.Forms.DateTimePicker OddateTimePicker;
    }
}