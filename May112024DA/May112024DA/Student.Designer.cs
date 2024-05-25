namespace May112024DA
{
    partial class Student
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
            this.MenuGb = new System.Windows.Forms.GroupBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.TeachersBtn = new System.Windows.Forms.Button();
            this.StudentsBtn = new System.Windows.Forms.Button();
            this.UsersBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.AddNewStdGB = new System.Windows.Forms.GroupBox();
            this.dobDTP = new System.Windows.Forms.DateTimePicker();
            this.DOBLbl = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ContactTb = new System.Windows.Forms.TextBox();
            this.ContactLbl = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.EmailTb = new System.Windows.Forms.TextBox();
            this.ShowAllBtn = new System.Windows.Forms.Button();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.NameLbl = new System.Windows.Forms.Label();
            this.IdTb = new System.Windows.Forms.TextBox();
            this.IdLbl = new System.Windows.Forms.Label();
            this.StudentsGB = new System.Windows.Forms.GroupBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.FindTb = new System.Windows.Forms.TextBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.StudentsGV = new System.Windows.Forms.DataGridView();
            this.MenuGb.SuspendLayout();
            this.AddNewStdGB.SuspendLayout();
            this.StudentsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuGb
            // 
            this.MenuGb.Controls.Add(this.ExitBtn);
            this.MenuGb.Controls.Add(this.TeachersBtn);
            this.MenuGb.Controls.Add(this.StudentsBtn);
            this.MenuGb.Controls.Add(this.UsersBtn);
            this.MenuGb.Controls.Add(this.HomeBtn);
            this.MenuGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuGb.Location = new System.Drawing.Point(12, 44);
            this.MenuGb.Name = "MenuGb";
            this.MenuGb.Size = new System.Drawing.Size(126, 394);
            this.MenuGb.TabIndex = 2;
            this.MenuGb.TabStop = false;
            this.MenuGb.Text = "Menu";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(18, 344);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            // 
            // TeachersBtn
            // 
            this.TeachersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeachersBtn.Location = new System.Drawing.Point(18, 112);
            this.TeachersBtn.Name = "TeachersBtn";
            this.TeachersBtn.Size = new System.Drawing.Size(75, 23);
            this.TeachersBtn.TabIndex = 6;
            this.TeachersBtn.Text = "Teachers";
            this.TeachersBtn.UseVisualStyleBackColor = true;
            // 
            // StudentsBtn
            // 
            this.StudentsBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StudentsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentsBtn.Location = new System.Drawing.Point(18, 83);
            this.StudentsBtn.Name = "StudentsBtn";
            this.StudentsBtn.Size = new System.Drawing.Size(75, 23);
            this.StudentsBtn.TabIndex = 5;
            this.StudentsBtn.Text = "Students";
            this.StudentsBtn.UseVisualStyleBackColor = false;
            // 
            // UsersBtn
            // 
            this.UsersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersBtn.Location = new System.Drawing.Point(18, 54);
            this.UsersBtn.Name = "UsersBtn";
            this.UsersBtn.Size = new System.Drawing.Size(75, 23);
            this.UsersBtn.TabIndex = 4;
            this.UsersBtn.Text = "Users";
            this.UsersBtn.UseVisualStyleBackColor = true;
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.Transparent;
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.Location = new System.Drawing.Point(18, 25);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(75, 23);
            this.HomeBtn.TabIndex = 3;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            // 
            // AddNewStdGB
            // 
            this.AddNewStdGB.Controls.Add(this.dobDTP);
            this.AddNewStdGB.Controls.Add(this.DOBLbl);
            this.AddNewStdGB.Controls.Add(this.DeleteBtn);
            this.AddNewStdGB.Controls.Add(this.ContactTb);
            this.AddNewStdGB.Controls.Add(this.ContactLbl);
            this.AddNewStdGB.Controls.Add(this.UpdateBtn);
            this.AddNewStdGB.Controls.Add(this.EmailTb);
            this.AddNewStdGB.Controls.Add(this.ShowAllBtn);
            this.AddNewStdGB.Controls.Add(this.EmailLbl);
            this.AddNewStdGB.Controls.Add(this.NameTb);
            this.AddNewStdGB.Controls.Add(this.InsertBtn);
            this.AddNewStdGB.Controls.Add(this.NameLbl);
            this.AddNewStdGB.Controls.Add(this.IdTb);
            this.AddNewStdGB.Controls.Add(this.IdLbl);
            this.AddNewStdGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewStdGB.Location = new System.Drawing.Point(145, 45);
            this.AddNewStdGB.Name = "AddNewStdGB";
            this.AddNewStdGB.Size = new System.Drawing.Size(643, 173);
            this.AddNewStdGB.TabIndex = 0;
            this.AddNewStdGB.TabStop = false;
            this.AddNewStdGB.Text = "Add/Edit New Student";
            this.AddNewStdGB.Enter += new System.EventHandler(this.AddNewStdGB_Enter);
            // 
            // dobDTP
            // 
            this.dobDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobDTP.Location = new System.Drawing.Point(88, 120);
            this.dobDTP.Name = "dobDTP";
            this.dobDTP.Size = new System.Drawing.Size(200, 20);
            this.dobDTP.TabIndex = 16;
            // 
            // DOBLbl
            // 
            this.DOBLbl.AutoSize = true;
            this.DOBLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBLbl.Location = new System.Drawing.Point(8, 123);
            this.DOBLbl.Name = "DOBLbl";
            this.DOBLbl.Size = new System.Drawing.Size(36, 15);
            this.DOBLbl.TabIndex = 11;
            this.DOBLbl.Text = "DOB";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(305, 118);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 21;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ContactTb
            // 
            this.ContactTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactTb.Location = new System.Drawing.Point(88, 146);
            this.ContactTb.Name = "ContactTb";
            this.ContactTb.Size = new System.Drawing.Size(200, 20);
            this.ContactTb.TabIndex = 17;
            // 
            // ContactLbl
            // 
            this.ContactLbl.AutoSize = true;
            this.ContactLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactLbl.Location = new System.Drawing.Point(8, 149);
            this.ContactLbl.Name = "ContactLbl";
            this.ContactLbl.Size = new System.Drawing.Size(77, 15);
            this.ContactLbl.TabIndex = 12;
            this.ContactLbl.Text = "Phone/Cell";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(305, 88);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 20;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // EmailTb
            // 
            this.EmailTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTb.Location = new System.Drawing.Point(88, 88);
            this.EmailTb.Name = "EmailTb";
            this.EmailTb.Size = new System.Drawing.Size(200, 20);
            this.EmailTb.TabIndex = 15;
            // 
            // ShowAllBtn
            // 
            this.ShowAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllBtn.Location = new System.Drawing.Point(305, 27);
            this.ShowAllBtn.Name = "ShowAllBtn";
            this.ShowAllBtn.Size = new System.Drawing.Size(75, 23);
            this.ShowAllBtn.TabIndex = 18;
            this.ShowAllBtn.Text = "Show All";
            this.ShowAllBtn.UseVisualStyleBackColor = true;
            this.ShowAllBtn.Click += new System.EventHandler(this.ShowAllBtn_Click);
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLbl.Location = new System.Drawing.Point(8, 91);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(44, 15);
            this.EmailLbl.TabIndex = 10;
            this.EmailLbl.Text = "Email";
            // 
            // NameTb
            // 
            this.NameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTb.Location = new System.Drawing.Point(88, 56);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(200, 20);
            this.NameTb.TabIndex = 14;
            // 
            // InsertBtn
            // 
            this.InsertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertBtn.Location = new System.Drawing.Point(305, 59);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(75, 23);
            this.InsertBtn.TabIndex = 19;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.Location = new System.Drawing.Point(8, 59);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(45, 15);
            this.NameLbl.TabIndex = 9;
            this.NameLbl.Text = "Name";
            // 
            // IdTb
            // 
            this.IdTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTb.Location = new System.Drawing.Point(88, 24);
            this.IdTb.Name = "IdTb";
            this.IdTb.Size = new System.Drawing.Size(200, 20);
            this.IdTb.TabIndex = 13;
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLbl.Location = new System.Drawing.Point(8, 27);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(74, 15);
            this.IdLbl.TabIndex = 8;
            this.IdLbl.Text = "Student ID";
            // 
            // StudentsGB
            // 
            this.StudentsGB.Controls.Add(this.SearchBtn);
            this.StudentsGB.Controls.Add(this.FindTb);
            this.StudentsGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentsGB.Location = new System.Drawing.Point(145, 224);
            this.StudentsGB.Name = "StudentsGB";
            this.StudentsGB.Size = new System.Drawing.Size(643, 56);
            this.StudentsGB.TabIndex = 22;
            this.StudentsGB.TabStop = false;
            this.StudentsGB.Text = "Students";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(213, 21);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 24;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            // 
            // FindTb
            // 
            this.FindTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindTb.Location = new System.Drawing.Point(6, 24);
            this.FindTb.Name = "FindTb";
            this.FindTb.Size = new System.Drawing.Size(190, 20);
            this.FindTb.TabIndex = 23;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(298, 13);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(129, 26);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "All Students";
            // 
            // StudentsGV
            // 
            this.StudentsGV.AllowUserToAddRows = false;
            this.StudentsGV.AllowUserToDeleteRows = false;
            this.StudentsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsGV.Location = new System.Drawing.Point(145, 286);
            this.StudentsGV.Name = "StudentsGV";
            this.StudentsGV.ReadOnly = true;
            this.StudentsGV.Size = new System.Drawing.Size(643, 152);
            this.StudentsGV.TabIndex = 25;
            this.StudentsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsGV_CellContentClick_1);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StudentsGV);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.StudentsGB);
            this.Controls.Add(this.AddNewStdGB);
            this.Controls.Add(this.MenuGb);
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.MenuGb.ResumeLayout(false);
            this.AddNewStdGB.ResumeLayout(false);
            this.AddNewStdGB.PerformLayout();
            this.StudentsGB.ResumeLayout(false);
            this.StudentsGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MenuGb;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button TeachersBtn;
        private System.Windows.Forms.Button StudentsBtn;
        private System.Windows.Forms.Button UsersBtn;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.GroupBox AddNewStdGB;
        private System.Windows.Forms.Label IdLbl;
        private System.Windows.Forms.DateTimePicker dobDTP;
        private System.Windows.Forms.Label DOBLbl;
        private System.Windows.Forms.TextBox EmailTb;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox IdTb;
        private System.Windows.Forms.TextBox ContactTb;
        private System.Windows.Forms.Label ContactLbl;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Button ShowAllBtn;
        private System.Windows.Forms.GroupBox StudentsGB;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox FindTb;
        private System.Windows.Forms.DataGridView StudentsGV;
    }
}