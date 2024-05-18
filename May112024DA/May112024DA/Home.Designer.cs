namespace May112024DA
{
    partial class Home
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
            this.TitleLbl = new System.Windows.Forms.Label();
            this.MenuGb = new System.Windows.Forms.GroupBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.TeachersBtn = new System.Windows.Forms.Button();
            this.StudentsBtn = new System.Windows.Forms.Button();
            this.UsersBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.OptionsGb = new System.Windows.Forms.GroupBox();
            this.GTExitBtn = new System.Windows.Forms.Button();
            this.GTStudentsBtn = new System.Windows.Forms.Button();
            this.GTTeachersBtn = new System.Windows.Forms.Button();
            this.GTHomeBtn = new System.Windows.Forms.Button();
            this.GTUserBtn = new System.Windows.Forms.Button();
            this.MenuGb.SuspendLayout();
            this.OptionsGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.Location = new System.Drawing.Point(280, 20);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(256, 26);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "Welcome to My School";
            // 
            // MenuGb
            // 
            this.MenuGb.Controls.Add(this.ExitBtn);
            this.MenuGb.Controls.Add(this.TeachersBtn);
            this.MenuGb.Controls.Add(this.StudentsBtn);
            this.MenuGb.Controls.Add(this.UsersBtn);
            this.MenuGb.Controls.Add(this.HomeBtn);
            this.MenuGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuGb.Location = new System.Drawing.Point(12, 20);
            this.MenuGb.Name = "MenuGb";
            this.MenuGb.Size = new System.Drawing.Size(126, 394);
            this.MenuGb.TabIndex = 1;
            this.MenuGb.TabStop = false;
            this.MenuGb.Text = "Menu";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(18, 344);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            // 
            // TeachersBtn
            // 
            this.TeachersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeachersBtn.Location = new System.Drawing.Point(18, 112);
            this.TeachersBtn.Name = "TeachersBtn";
            this.TeachersBtn.Size = new System.Drawing.Size(75, 23);
            this.TeachersBtn.TabIndex = 0;
            this.TeachersBtn.Text = "Teachers";
            this.TeachersBtn.UseVisualStyleBackColor = true;
            // 
            // StudentsBtn
            // 
            this.StudentsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentsBtn.Location = new System.Drawing.Point(18, 83);
            this.StudentsBtn.Name = "StudentsBtn";
            this.StudentsBtn.Size = new System.Drawing.Size(75, 23);
            this.StudentsBtn.TabIndex = 0;
            this.StudentsBtn.Text = "Students";
            this.StudentsBtn.UseVisualStyleBackColor = true;
            this.StudentsBtn.Click += new System.EventHandler(this.StudentsBtn_Click);
            // 
            // UsersBtn
            // 
            this.UsersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersBtn.Location = new System.Drawing.Point(18, 54);
            this.UsersBtn.Name = "UsersBtn";
            this.UsersBtn.Size = new System.Drawing.Size(75, 23);
            this.UsersBtn.TabIndex = 0;
            this.UsersBtn.Text = "Users";
            this.UsersBtn.UseVisualStyleBackColor = true;
            this.UsersBtn.Click += new System.EventHandler(this.UsersBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.Location = new System.Drawing.Point(18, 25);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(75, 23);
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // OptionsGb
            // 
            this.OptionsGb.Controls.Add(this.GTExitBtn);
            this.OptionsGb.Controls.Add(this.GTStudentsBtn);
            this.OptionsGb.Controls.Add(this.GTTeachersBtn);
            this.OptionsGb.Controls.Add(this.GTHomeBtn);
            this.OptionsGb.Controls.Add(this.GTUserBtn);
            this.OptionsGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsGb.Location = new System.Drawing.Point(144, 49);
            this.OptionsGb.Name = "OptionsGb";
            this.OptionsGb.Size = new System.Drawing.Size(536, 365);
            this.OptionsGb.TabIndex = 2;
            this.OptionsGb.TabStop = false;
            this.OptionsGb.Text = "Go To";
            // 
            // GTExitBtn
            // 
            this.GTExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GTExitBtn.Location = new System.Drawing.Point(192, 236);
            this.GTExitBtn.Name = "GTExitBtn";
            this.GTExitBtn.Size = new System.Drawing.Size(150, 46);
            this.GTExitBtn.TabIndex = 0;
            this.GTExitBtn.Text = "Exit";
            this.GTExitBtn.UseVisualStyleBackColor = true;
            // 
            // GTStudentsBtn
            // 
            this.GTStudentsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GTStudentsBtn.Location = new System.Drawing.Point(28, 137);
            this.GTStudentsBtn.Name = "GTStudentsBtn";
            this.GTStudentsBtn.Size = new System.Drawing.Size(150, 46);
            this.GTStudentsBtn.TabIndex = 0;
            this.GTStudentsBtn.Text = "Students";
            this.GTStudentsBtn.UseVisualStyleBackColor = true;
            this.GTStudentsBtn.Click += new System.EventHandler(this.GTStudentsBtn_Click);
            // 
            // GTTeachersBtn
            // 
            this.GTTeachersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GTTeachersBtn.Location = new System.Drawing.Point(363, 137);
            this.GTTeachersBtn.Name = "GTTeachersBtn";
            this.GTTeachersBtn.Size = new System.Drawing.Size(150, 46);
            this.GTTeachersBtn.TabIndex = 0;
            this.GTTeachersBtn.Text = "Teachers";
            this.GTTeachersBtn.UseVisualStyleBackColor = true;
            // 
            // GTHomeBtn
            // 
            this.GTHomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GTHomeBtn.Location = new System.Drawing.Point(28, 42);
            this.GTHomeBtn.Name = "GTHomeBtn";
            this.GTHomeBtn.Size = new System.Drawing.Size(150, 46);
            this.GTHomeBtn.TabIndex = 0;
            this.GTHomeBtn.Text = "Home";
            this.GTHomeBtn.UseVisualStyleBackColor = true;
            this.GTHomeBtn.Click += new System.EventHandler(this.GTHomeBtn_Click);
            // 
            // GTUserBtn
            // 
            this.GTUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GTUserBtn.Location = new System.Drawing.Point(363, 42);
            this.GTUserBtn.Name = "GTUserBtn";
            this.GTUserBtn.Size = new System.Drawing.Size(150, 46);
            this.GTUserBtn.TabIndex = 0;
            this.GTUserBtn.Text = "Users";
            this.GTUserBtn.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OptionsGb);
            this.Controls.Add(this.MenuGb);
            this.Controls.Add(this.TitleLbl);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.MenuGb.ResumeLayout(false);
            this.OptionsGb.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.GroupBox MenuGb;
        private System.Windows.Forms.Button TeachersBtn;
        private System.Windows.Forms.Button StudentsBtn;
        private System.Windows.Forms.Button UsersBtn;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.GroupBox OptionsGb;
        private System.Windows.Forms.Button GTExitBtn;
        private System.Windows.Forms.Button GTStudentsBtn;
        private System.Windows.Forms.Button GTTeachersBtn;
        private System.Windows.Forms.Button GTHomeBtn;
        private System.Windows.Forms.Button GTUserBtn;
    }
}