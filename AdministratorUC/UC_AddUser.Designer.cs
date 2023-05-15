namespace Medical_Store_Management_System.AdministratorUC
{
    partial class UC_AddUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUserRole = new System.Windows.Forms.ComboBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserMob = new System.Windows.Forms.TextBox();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.txtUserUsername = new System.Windows.Forms.TextBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.txtUserDOB = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.btnUserReset = new System.Windows.Forms.Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "DOB (Date of Birth)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(129, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mobile No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(602, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email Address";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(602, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(602, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Password";
            // 
            // txtUserRole
            // 
            this.txtUserRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserRole.ForeColor = System.Drawing.Color.Black;
            this.txtUserRole.FormattingEnabled = true;
            this.txtUserRole.Items.AddRange(new object[] {
            "Administrator",
            "Pharmacist"});
            this.txtUserRole.Location = new System.Drawing.Point(133, 183);
            this.txtUserRole.Name = "txtUserRole";
            this.txtUserRole.Size = new System.Drawing.Size(340, 29);
            this.txtUserRole.TabIndex = 9;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.Location = new System.Drawing.Point(133, 280);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(340, 29);
            this.txtUserName.TabIndex = 10;
            // 
            // txtUserMob
            // 
            this.txtUserMob.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserMob.ForeColor = System.Drawing.Color.Black;
            this.txtUserMob.Location = new System.Drawing.Point(133, 456);
            this.txtUserMob.Name = "txtUserMob";
            this.txtUserMob.Size = new System.Drawing.Size(340, 29);
            this.txtUserMob.TabIndex = 11;
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserEmail.ForeColor = System.Drawing.Color.Black;
            this.txtUserEmail.Location = new System.Drawing.Point(606, 183);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(340, 29);
            this.txtUserEmail.TabIndex = 12;
            // 
            // txtUserUsername
            // 
            this.txtUserUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUserUsername.Location = new System.Drawing.Point(606, 280);
            this.txtUserUsername.Name = "txtUserUsername";
            this.txtUserUsername.Size = new System.Drawing.Size(340, 29);
            this.txtUserUsername.TabIndex = 13;
            this.txtUserUsername.TextChanged += new System.EventHandler(this.txtUserUsername_TextChanged);
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPassword.ForeColor = System.Drawing.Color.Black;
            this.txtUserPassword.Location = new System.Drawing.Point(606, 374);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(340, 29);
            this.txtUserPassword.TabIndex = 14;
            // 
            // txtUserDOB
            // 
            this.txtUserDOB.Location = new System.Drawing.Point(133, 374);
            this.txtUserDOB.Name = "txtUserDOB";
            this.txtUserDOB.Size = new System.Drawing.Size(340, 20);
            this.txtUserDOB.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.panel1.Location = new System.Drawing.Point(535, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 523);
            this.panel1.TabIndex = 16;
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnUserAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserAdd.Image = global::Medical_Store_Management_System.Properties.Resources.signup_64px;
            this.btnUserAdd.Location = new System.Drawing.Point(618, 446);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(128, 46);
            this.btnUserAdd.TabIndex = 17;
            this.btnUserAdd.Text = "Add";
            this.btnUserAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserAdd.UseVisualStyleBackColor = false;
            this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
            // 
            // btnUserReset
            // 
            this.btnUserReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnUserReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserReset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserReset.Image = global::Medical_Store_Management_System.Properties.Resources.reset_25px;
            this.btnUserReset.Location = new System.Drawing.Point(776, 446);
            this.btnUserReset.Name = "btnUserReset";
            this.btnUserReset.Size = new System.Drawing.Size(128, 46);
            this.btnUserReset.TabIndex = 18;
            this.btnUserReset.Text = "Reset";
            this.btnUserReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserReset.UseVisualStyleBackColor = false;
            this.btnUserReset.Click += new System.EventHandler(this.btnUserReset_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(952, 280);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(641, 504);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(233, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "*Check user role once before inserting";
            // 
            // UC_AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUserReset);
            this.Controls.Add(this.btnUserAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtUserDOB);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.txtUserUsername);
            this.Controls.Add(this.txtUserEmail);
            this.Controls.Add(this.txtUserMob);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtUserRole);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_AddUser";
            this.Size = new System.Drawing.Size(1105, 771);
            this.Load += new System.EventHandler(this.UC_AddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txtUserRole;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserMob;
        private System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.TextBox txtUserUsername;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.DateTimePicker txtUserDOB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUserAdd;
        private System.Windows.Forms.Button btnUserReset;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
