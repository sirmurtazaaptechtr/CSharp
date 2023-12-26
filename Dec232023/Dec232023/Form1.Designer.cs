namespace Dec232023
{
    partial class Form1
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
            this.AppLbl = new System.Windows.Forms.Label();
            this.IdLbl = new System.Windows.Forms.Label();
            this.IdTb = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.AddressTb = new System.Windows.Forms.TextBox();
            this.SalaryLbl = new System.Windows.Forms.Label();
            this.SalaryTb = new System.Windows.Forms.TextBox();
            this.FindBtn = new System.Windows.Forms.Button();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.TeachersDGV = new System.Windows.Forms.DataGridView();
            this.schoolDataSet = new Dec232023.schoolDataSet();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersTableAdapter = new Dec232023.schoolDataSetTableAdapters.teachersTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AppLbl
            // 
            this.AppLbl.AutoSize = true;
            this.AppLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppLbl.Location = new System.Drawing.Point(13, 13);
            this.AppLbl.Name = "AppLbl";
            this.AppLbl.Size = new System.Drawing.Size(165, 20);
            this.AppLbl.TabIndex = 0;
            this.AppLbl.Text = "Teacher Management";
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Location = new System.Drawing.Point(17, 45);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(61, 13);
            this.IdLbl.TabIndex = 1;
            this.IdLbl.Text = "Teacher ID";
            // 
            // IdTb
            // 
            this.IdTb.Location = new System.Drawing.Point(92, 45);
            this.IdTb.Name = "IdTb";
            this.IdTb.Size = new System.Drawing.Size(168, 20);
            this.IdTb.TabIndex = 2;
            this.IdTb.TextChanged += new System.EventHandler(this.IdTb_TextChanged);
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(17, 74);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(54, 13);
            this.NameLbl.TabIndex = 3;
            this.NameLbl.Text = "Full Name";
            this.NameLbl.Click += new System.EventHandler(this.NameLbl_Click);
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(92, 71);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(168, 20);
            this.NameTb.TabIndex = 4;
            this.NameTb.TextChanged += new System.EventHandler(this.NameTb_TextChanged);
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Location = new System.Drawing.Point(17, 100);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(45, 13);
            this.AddressLbl.TabIndex = 5;
            this.AddressLbl.Text = "Address";
            this.AddressLbl.Click += new System.EventHandler(this.AddressLbl_Click);
            // 
            // AddressTb
            // 
            this.AddressTb.Location = new System.Drawing.Point(92, 97);
            this.AddressTb.Multiline = true;
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.Size = new System.Drawing.Size(168, 40);
            this.AddressTb.TabIndex = 6;
            this.AddressTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SalaryLbl
            // 
            this.SalaryLbl.AutoSize = true;
            this.SalaryLbl.Location = new System.Drawing.Point(20, 145);
            this.SalaryLbl.Name = "SalaryLbl";
            this.SalaryLbl.Size = new System.Drawing.Size(68, 13);
            this.SalaryLbl.TabIndex = 7;
            this.SalaryLbl.Text = "Salary (USD)";
            this.SalaryLbl.Click += new System.EventHandler(this.SalaryLbl_Click);
            // 
            // SalaryTb
            // 
            this.SalaryTb.Location = new System.Drawing.Point(92, 142);
            this.SalaryTb.Name = "SalaryTb";
            this.SalaryTb.Size = new System.Drawing.Size(168, 20);
            this.SalaryTb.TabIndex = 8;
            this.SalaryTb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // FindBtn
            // 
            this.FindBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.FindBtn.Location = new System.Drawing.Point(104, 197);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(75, 23);
            this.FindBtn.TabIndex = 10;
            this.FindBtn.Text = "Find";
            this.FindBtn.UseVisualStyleBackColor = false;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // InsertBtn
            // 
            this.InsertBtn.Location = new System.Drawing.Point(23, 168);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(75, 23);
            this.InsertBtn.TabIndex = 11;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(104, 168);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 11;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(185, 168);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 11;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ShowBtn
            // 
            this.ShowBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ShowBtn.Location = new System.Drawing.Point(23, 197);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(75, 23);
            this.ShowBtn.TabIndex = 11;
            this.ShowBtn.Text = "Show All";
            this.ShowBtn.UseVisualStyleBackColor = false;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Crimson;
            this.ExitBtn.Location = new System.Drawing.Point(185, 197);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 11;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // TeachersDGV
            // 
            this.TeachersDGV.AutoGenerateColumns = false;
            this.TeachersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeachersDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn});
            this.TeachersDGV.DataSource = this.teachersBindingSource;
            this.TeachersDGV.Location = new System.Drawing.Point(273, 45);
            this.TeachersDGV.Name = "TeachersDGV";
            this.TeachersDGV.Size = new System.Drawing.Size(525, 175);
            this.TeachersDGV.TabIndex = 12;
            // 
            // schoolDataSet
            // 
            this.schoolDataSet.DataSetName = "schoolDataSet";
            this.schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "teachers";
            this.teachersBindingSource.DataSource = this.schoolDataSet;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 261);
            this.Controls.Add(this.TeachersDGV);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ShowBtn);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.FindBtn);
            this.Controls.Add(this.SalaryTb);
            this.Controls.Add(this.SalaryLbl);
            this.Controls.Add(this.AddressTb);
            this.Controls.Add(this.AddressLbl);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.IdTb);
            this.Controls.Add(this.IdLbl);
            this.Controls.Add(this.AppLbl);
            this.Name = "Form1";
            this.Text = "Manage Teachers";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TeachersDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppLbl;
        private System.Windows.Forms.Label IdLbl;
        private System.Windows.Forms.TextBox IdTb;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.TextBox AddressTb;
        private System.Windows.Forms.Label SalaryLbl;
        private System.Windows.Forms.TextBox SalaryTb;
        private System.Windows.Forms.Button FindBtn;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ShowBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.DataGridView TeachersDGV;
        private schoolDataSet schoolDataSet;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private schoolDataSetTableAdapters.teachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
    }
}

