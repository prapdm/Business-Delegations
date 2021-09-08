
namespace Delegacje_Służbowe
{
    partial class UsersList
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
            this.OperationsgroupBox = new System.Windows.Forms.GroupBox();
            this.newUserbutton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exportButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
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
            this.OperationsgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // OperationsgroupBox
            // 
            this.OperationsgroupBox.Controls.Add(this.newUserbutton);
            this.OperationsgroupBox.Controls.Add(this.textBox2);
            this.OperationsgroupBox.Controls.Add(this.label1);
            this.OperationsgroupBox.Controls.Add(this.exportButton);
            this.OperationsgroupBox.Controls.Add(this.printButton);
            this.OperationsgroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.OperationsgroupBox.Location = new System.Drawing.Point(684, 0);
            this.OperationsgroupBox.Name = "OperationsgroupBox";
            this.OperationsgroupBox.Size = new System.Drawing.Size(231, 588);
            this.OperationsgroupBox.TabIndex = 4;
            this.OperationsgroupBox.TabStop = false;
            this.OperationsgroupBox.Text = "Operacje";
            // 
            // newUserbutton
            // 
            this.newUserbutton.Location = new System.Drawing.Point(18, 93);
            this.newUserbutton.Name = "newUserbutton";
            this.newUserbutton.Size = new System.Drawing.Size(201, 39);
            this.newUserbutton.TabIndex = 4;
            this.newUserbutton.Text = "Nowy pracownik";
            this.newUserbutton.UseVisualStyleBackColor = true;
            this.newUserbutton.Click += new System.EventHandler(this.NewUserbutton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(18, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 23);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtruj:";
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(18, 183);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(201, 39);
            this.exportButton.TabIndex = 1;
            this.exportButton.Text = "Exportuj do Excel";
            this.exportButton.UseVisualStyleBackColor = true;
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(18, 138);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(201, 39);
            this.printButton.TabIndex = 0;
            this.printButton.Text = "Exportuj do PDF";
            this.printButton.UseVisualStyleBackColor = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(684, 588);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_MouseClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
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
            // UsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 588);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.OperationsgroupBox);
            this.Name = "UsersList";
            this.ShowIcon = false;
            this.Text = "Lista pracowników";
            this.OperationsgroupBox.ResumeLayout(false);
            this.OperationsgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox OperationsgroupBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button newUserbutton;
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