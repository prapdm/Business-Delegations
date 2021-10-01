
namespace Delegations
{
    partial class UsersListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersListForm));
            this.OperationsgroupBox = new System.Windows.Forms.GroupBox();
            this.newUserbutton = new System.Windows.Forms.Button();
            this.ExportToCSV = new System.Windows.Forms.Button();
            this.ExportToPDF = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FiltrLabel = new System.Windows.Forms.Label();
            this.FilterButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.OperationsgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OperationsgroupBox
            // 
            this.OperationsgroupBox.Controls.Add(this.newUserbutton);
            this.OperationsgroupBox.Controls.Add(this.ExportToCSV);
            this.OperationsgroupBox.Controls.Add(this.ExportToPDF);
            this.OperationsgroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.OperationsgroupBox.Location = new System.Drawing.Point(856, 0);
            this.OperationsgroupBox.Name = "OperationsgroupBox";
            this.OperationsgroupBox.Size = new System.Drawing.Size(231, 584);
            this.OperationsgroupBox.TabIndex = 4;
            this.OperationsgroupBox.TabStop = false;
            this.OperationsgroupBox.Text = "Operacje";
            // 
            // newUserbutton
            // 
            this.newUserbutton.Location = new System.Drawing.Point(18, 37);
            this.newUserbutton.Name = "newUserbutton";
            this.newUserbutton.Size = new System.Drawing.Size(201, 39);
            this.newUserbutton.TabIndex = 4;
            this.newUserbutton.Text = "Nowy pracownik";
            this.newUserbutton.UseVisualStyleBackColor = true;
            this.newUserbutton.Click += new System.EventHandler(this.NewUserbutton_Click);
            // 
            // ExportToCSV
            // 
            this.ExportToCSV.Location = new System.Drawing.Point(18, 127);
            this.ExportToCSV.Name = "ExportToCSV";
            this.ExportToCSV.Size = new System.Drawing.Size(201, 39);
            this.ExportToCSV.TabIndex = 1;
            this.ExportToCSV.Text = "Exportuj do CSV";
            this.ExportToCSV.UseVisualStyleBackColor = true;
            this.ExportToCSV.Click += new System.EventHandler(this.ExportToCSV_Click);
            // 
            // ExportToPDF
            // 
            this.ExportToPDF.Location = new System.Drawing.Point(18, 82);
            this.ExportToPDF.Name = "ExportToPDF";
            this.ExportToPDF.Size = new System.Drawing.Size(201, 39);
            this.ExportToPDF.TabIndex = 0;
            this.ExportToPDF.Text = "Exportuj do PDF";
            this.ExportToPDF.UseVisualStyleBackColor = true;
            this.ExportToPDF.Click += new System.EventHandler(this.ExportToPDF_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(61, 6);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(577, 23);
            this.SearchTextBox.TabIndex = 3;
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
            this.login,
            this.department,
            this.role,
            this.status,
            this.created_at,
            this.updated_at});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(850, 538);
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
            // login
            // 
            this.login.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.login.DataPropertyName = "login";
            this.login.HeaderText = "Login";
            this.login.Name = "login";
            this.login.ReadOnly = true;
            // 
            // department
            // 
            this.department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.department.DataPropertyName = "department";
            this.department.HeaderText = "Departament";
            this.department.Name = "department";
            this.department.ReadOnly = true;
            // 
            // role
            // 
            this.role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.role.HeaderText = "Rola";
            this.role.Name = "role";
            this.role.ReadOnly = true;
            this.role.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.DataPropertyName = "Status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(856, 584);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FiltrLabel);
            this.panel1.Controls.Add(this.FilterButton);
            this.panel1.Controls.Add(this.SearchTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 547);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 34);
            this.panel1.TabIndex = 2;
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
            this.FilterButton.Location = new System.Drawing.Point(644, 1);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(31, 30);
            this.FilterButton.TabIndex = 5;
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // UsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 584);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.OperationsgroupBox);
            this.Name = "UsersList";
            this.ShowIcon = false;
            this.Text = "Lista pracowników";
            this.OperationsgroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox OperationsgroupBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button ExportToCSV;
        private System.Windows.Forms.Button ExportToPDF;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button newUserbutton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label FiltrLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_at;
    }
}