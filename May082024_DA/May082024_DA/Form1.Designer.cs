namespace May082024_DA
{
    partial class Teachers
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
            this.IDlbl = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            this.Addresslbl = new System.Windows.Forms.Label();
            this.Salarylbl = new System.Windows.Forms.Label();
            this.IDtb = new System.Windows.Forms.TextBox();
            this.Nametb = new System.Windows.Forms.TextBox();
            this.Addresstb = new System.Windows.Forms.TextBox();
            this.Salarytb = new System.Windows.Forms.TextBox();
            this.Findtb = new System.Windows.Forms.TextBox();
            this.Insertbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Showallbtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.Findbtn = new System.Windows.Forms.Button();
            this.Teachersgv = new System.Windows.Forms.DataGridView();
            this.school_dbDataSet = new May082024_DA.school_dbDataSet();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherTableAdapter = new May082024_DA.school_dbDataSetTableAdapters.teacherTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Teachersgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // IDlbl
            // 
            this.IDlbl.AutoSize = true;
            this.IDlbl.Location = new System.Drawing.Point(8, 42);
            this.IDlbl.Name = "IDlbl";
            this.IDlbl.Size = new System.Drawing.Size(61, 13);
            this.IDlbl.TabIndex = 0;
            this.IDlbl.Text = "Teacher ID";
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Location = new System.Drawing.Point(8, 69);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(35, 13);
            this.Namelbl.TabIndex = 0;
            this.Namelbl.Text = "Name";
            // 
            // Addresslbl
            // 
            this.Addresslbl.AutoSize = true;
            this.Addresslbl.Location = new System.Drawing.Point(8, 95);
            this.Addresslbl.Name = "Addresslbl";
            this.Addresslbl.Size = new System.Drawing.Size(45, 13);
            this.Addresslbl.TabIndex = 0;
            this.Addresslbl.Text = "Address";
            // 
            // Salarylbl
            // 
            this.Salarylbl.AutoSize = true;
            this.Salarylbl.Location = new System.Drawing.Point(8, 121);
            this.Salarylbl.Name = "Salarylbl";
            this.Salarylbl.Size = new System.Drawing.Size(36, 13);
            this.Salarylbl.TabIndex = 0;
            this.Salarylbl.Text = "Salary";
            // 
            // IDtb
            // 
            this.IDtb.Location = new System.Drawing.Point(78, 42);
            this.IDtb.Name = "IDtb";
            this.IDtb.Size = new System.Drawing.Size(170, 20);
            this.IDtb.TabIndex = 1;
            this.IDtb.TextChanged += new System.EventHandler(this.IDtb_TextChanged);
            // 
            // Nametb
            // 
            this.Nametb.Location = new System.Drawing.Point(78, 69);
            this.Nametb.Name = "Nametb";
            this.Nametb.Size = new System.Drawing.Size(170, 20);
            this.Nametb.TabIndex = 1;
            this.Nametb.TextChanged += new System.EventHandler(this.Nametb_TextChanged);
            // 
            // Addresstb
            // 
            this.Addresstb.Location = new System.Drawing.Point(78, 95);
            this.Addresstb.Name = "Addresstb";
            this.Addresstb.Size = new System.Drawing.Size(170, 20);
            this.Addresstb.TabIndex = 1;
            this.Addresstb.TextChanged += new System.EventHandler(this.Addresstb_TextChanged);
            // 
            // Salarytb
            // 
            this.Salarytb.Location = new System.Drawing.Point(78, 121);
            this.Salarytb.Name = "Salarytb";
            this.Salarytb.Size = new System.Drawing.Size(170, 20);
            this.Salarytb.TabIndex = 1;
            this.Salarytb.TextChanged += new System.EventHandler(this.Salarytb_TextChanged);
            // 
            // Findtb
            // 
            this.Findtb.Location = new System.Drawing.Point(254, 42);
            this.Findtb.Name = "Findtb";
            this.Findtb.Size = new System.Drawing.Size(437, 20);
            this.Findtb.TabIndex = 1;
            // 
            // Insertbtn
            // 
            this.Insertbtn.Location = new System.Drawing.Point(11, 169);
            this.Insertbtn.Name = "Insertbtn";
            this.Insertbtn.Size = new System.Drawing.Size(75, 23);
            this.Insertbtn.TabIndex = 2;
            this.Insertbtn.Text = "Insert";
            this.Insertbtn.UseVisualStyleBackColor = true;
            this.Insertbtn.Click += new System.EventHandler(this.Insertbtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Location = new System.Drawing.Point(92, 169);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(75, 23);
            this.Updatebtn.TabIndex = 2;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(173, 169);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(75, 23);
            this.Deletebtn.TabIndex = 2;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Showallbtn
            // 
            this.Showallbtn.Location = new System.Drawing.Point(11, 198);
            this.Showallbtn.Name = "Showallbtn";
            this.Showallbtn.Size = new System.Drawing.Size(75, 23);
            this.Showallbtn.TabIndex = 2;
            this.Showallbtn.Text = "Show All";
            this.Showallbtn.UseVisualStyleBackColor = true;
            this.Showallbtn.Click += new System.EventHandler(this.Showallbtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.BackColor = System.Drawing.Color.Red;
            this.Exitbtn.ForeColor = System.Drawing.Color.White;
            this.Exitbtn.Location = new System.Drawing.Point(173, 198);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(75, 23);
            this.Exitbtn.TabIndex = 2;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = false;
            // 
            // Findbtn
            // 
            this.Findbtn.BackColor = System.Drawing.Color.Lime;
            this.Findbtn.Location = new System.Drawing.Point(697, 40);
            this.Findbtn.Name = "Findbtn";
            this.Findbtn.Size = new System.Drawing.Size(75, 23);
            this.Findbtn.TabIndex = 2;
            this.Findbtn.Text = "Find";
            this.Findbtn.UseVisualStyleBackColor = false;
            // 
            // Teachersgv
            // 
            this.Teachersgv.AutoGenerateColumns = false;
            this.Teachersgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Teachersgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn});
            this.Teachersgv.DataSource = this.teacherBindingSource;
            this.Teachersgv.Location = new System.Drawing.Point(254, 69);
            this.Teachersgv.Name = "Teachersgv";
            this.Teachersgv.Size = new System.Drawing.Size(437, 150);
            this.Teachersgv.TabIndex = 3;
            this.Teachersgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Teachersgv_CellContentClick);
            // 
            // school_dbDataSet
            // 
            this.school_dbDataSet.DataSetName = "school_dbDataSet";
            this.school_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "teacher";
            this.teacherBindingSource.DataSource = this.school_dbDataSet;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
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
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.Teachersgv);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.Findbtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Showallbtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Insertbtn);
            this.Controls.Add(this.Salarytb);
            this.Controls.Add(this.Addresstb);
            this.Controls.Add(this.Nametb);
            this.Controls.Add(this.Findtb);
            this.Controls.Add(this.IDtb);
            this.Controls.Add(this.Salarylbl);
            this.Controls.Add(this.Addresslbl);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.IDlbl);
            this.Name = "Teachers";
            this.Text = "Teachers";
            this.Load += new System.EventHandler(this.Teachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Teachersgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDlbl;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label Addresslbl;
        private System.Windows.Forms.Label Salarylbl;
        private System.Windows.Forms.TextBox IDtb;
        private System.Windows.Forms.TextBox Nametb;
        private System.Windows.Forms.TextBox Addresstb;
        private System.Windows.Forms.TextBox Salarytb;
        private System.Windows.Forms.TextBox Findtb;
        private System.Windows.Forms.Button Insertbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Showallbtn;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Button Findbtn;
        private System.Windows.Forms.DataGridView Teachersgv;
        private school_dbDataSet school_dbDataSet;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private school_dbDataSetTableAdapters.teacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
    }
}

