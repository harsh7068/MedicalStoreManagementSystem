namespace Medical_Store_Management_System
{
    partial class Pharmacist
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSellMedicine = new System.Windows.Forms.Button();
            this.btnMedValCheck = new System.Windows.Forms.Button();
            this.btnModifyMedicine = new System.Windows.Forms.Button();
            this.btnViewMedicine = new System.Windows.Forms.Button();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uC_P_MedValidityCheck1 = new Medical_Store_Management_System.PharmacistUC.UC_P_MedValidityCheck();
            this.uC_P_ModifyMedicine1 = new Medical_Store_Management_System.PharmacistUC.UC_P_ModifyMedicine();
            this.uC_P_ViewMedicine1 = new Medical_Store_Management_System.PharmacistUC.UC_P_ViewMedicine();
            this.uC_P_AddMedicine1 = new Medical_Store_Management_System.PharmacistUC.UC_P_AddMedicine();
            this.uC_P_Dashboard1 = new Medical_Store_Management_System.PharmacistUC.UC_P_Dashboard();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_P_SellMedicines1 = new Medical_Store_Management_System.PharmacistUC.UC_P_SellMedicines();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnSellMedicine);
            this.panel1.Controls.Add(this.btnMedValCheck);
            this.panel1.Controls.Add(this.btnModifyMedicine);
            this.panel1.Controls.Add(this.btnViewMedicine);
            this.panel1.Controls.Add(this.btnAddMedicine);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 780);
            this.panel1.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::Medical_Store_Management_System.Properties.Resources.logout;
            this.btnLogout.Location = new System.Drawing.Point(40, 671);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(194, 47);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSellMedicine
            // 
            this.btnSellMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSellMedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSellMedicine.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSellMedicine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellMedicine.ForeColor = System.Drawing.Color.White;
            this.btnSellMedicine.Image = global::Medical_Store_Management_System.Properties.Resources.sellMedicine_64px;
            this.btnSellMedicine.Location = new System.Drawing.Point(40, 607);
            this.btnSellMedicine.Name = "btnSellMedicine";
            this.btnSellMedicine.Size = new System.Drawing.Size(194, 47);
            this.btnSellMedicine.TabIndex = 10;
            this.btnSellMedicine.Text = "Sell Medicine";
            this.btnSellMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSellMedicine.UseVisualStyleBackColor = false;
            this.btnSellMedicine.Click += new System.EventHandler(this.btnSellMedicine_Click);
            // 
            // btnMedValCheck
            // 
            this.btnMedValCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnMedValCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedValCheck.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMedValCheck.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedValCheck.ForeColor = System.Drawing.Color.White;
            this.btnMedValCheck.Image = global::Medical_Store_Management_System.Properties.Resources.MedicineValidation_40px;
            this.btnMedValCheck.Location = new System.Drawing.Point(40, 543);
            this.btnMedValCheck.Name = "btnMedValCheck";
            this.btnMedValCheck.Size = new System.Drawing.Size(194, 47);
            this.btnMedValCheck.TabIndex = 9;
            this.btnMedValCheck.Text = "Medicine Validity Check";
            this.btnMedValCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMedValCheck.UseVisualStyleBackColor = false;
            this.btnMedValCheck.Click += new System.EventHandler(this.btnMedValCheck_Click);
            // 
            // btnModifyMedicine
            // 
            this.btnModifyMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnModifyMedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifyMedicine.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModifyMedicine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyMedicine.ForeColor = System.Drawing.Color.White;
            this.btnModifyMedicine.Image = global::Medical_Store_Management_System.Properties.Resources.modifyMedicine_32px;
            this.btnModifyMedicine.Location = new System.Drawing.Point(40, 480);
            this.btnModifyMedicine.Name = "btnModifyMedicine";
            this.btnModifyMedicine.Size = new System.Drawing.Size(194, 47);
            this.btnModifyMedicine.TabIndex = 8;
            this.btnModifyMedicine.Text = "Modify Medicine";
            this.btnModifyMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModifyMedicine.UseVisualStyleBackColor = false;
            this.btnModifyMedicine.Click += new System.EventHandler(this.btnModifyMedicine_Click);
            // 
            // btnViewMedicine
            // 
            this.btnViewMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnViewMedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewMedicine.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewMedicine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMedicine.ForeColor = System.Drawing.Color.White;
            this.btnViewMedicine.Image = global::Medical_Store_Management_System.Properties.Resources.view_64px;
            this.btnViewMedicine.Location = new System.Drawing.Point(40, 417);
            this.btnViewMedicine.Name = "btnViewMedicine";
            this.btnViewMedicine.Size = new System.Drawing.Size(194, 47);
            this.btnViewMedicine.TabIndex = 7;
            this.btnViewMedicine.Text = "View Medicine";
            this.btnViewMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewMedicine.UseVisualStyleBackColor = false;
            this.btnViewMedicine.Click += new System.EventHandler(this.btnViewMedicine_Click);
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnAddMedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMedicine.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddMedicine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedicine.ForeColor = System.Drawing.Color.White;
            this.btnAddMedicine.Image = global::Medical_Store_Management_System.Properties.Resources.addMedic_48px;
            this.btnAddMedicine.Location = new System.Drawing.Point(40, 353);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(194, 47);
            this.btnAddMedicine.TabIndex = 6;
            this.btnAddMedicine.Text = "Add Medicine";
            this.btnAddMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddMedicine.UseVisualStyleBackColor = false;
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::Medical_Store_Management_System.Properties.Resources.dashbord;
            this.btnDashboard.Location = new System.Drawing.Point(40, 288);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(194, 47);
            this.btnDashboard.TabIndex = 5;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pharmacist";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Medical_Store_Management_System.Properties.Resources.pharmacy_100px1;
            this.pictureBox1.Location = new System.Drawing.Point(44, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(276, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1093, 780);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.uC_P_SellMedicines1);
            this.panel3.Controls.Add(this.uC_P_MedValidityCheck1);
            this.panel3.Controls.Add(this.uC_P_ModifyMedicine1);
            this.panel3.Controls.Add(this.uC_P_ViewMedicine1);
            this.panel3.Controls.Add(this.uC_P_AddMedicine1);
            this.panel3.Controls.Add(this.uC_P_Dashboard1);
            this.panel3.Location = new System.Drawing.Point(275, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1094, 780);
            this.panel3.TabIndex = 2;
            // 
            // uC_P_MedValidityCheck1
            // 
            this.uC_P_MedValidityCheck1.BackColor = System.Drawing.Color.White;
            this.uC_P_MedValidityCheck1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_MedValidityCheck1.Name = "uC_P_MedValidityCheck1";
            this.uC_P_MedValidityCheck1.Size = new System.Drawing.Size(1094, 780);
            this.uC_P_MedValidityCheck1.TabIndex = 4;
            // 
            // uC_P_ModifyMedicine1
            // 
            this.uC_P_ModifyMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_P_ModifyMedicine1.Location = new System.Drawing.Point(-1, 0);
            this.uC_P_ModifyMedicine1.Name = "uC_P_ModifyMedicine1";
            this.uC_P_ModifyMedicine1.Size = new System.Drawing.Size(1094, 780);
            this.uC_P_ModifyMedicine1.TabIndex = 3;
            // 
            // uC_P_ViewMedicine1
            // 
            this.uC_P_ViewMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_P_ViewMedicine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_P_ViewMedicine1.Location = new System.Drawing.Point(0, 1);
            this.uC_P_ViewMedicine1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uC_P_ViewMedicine1.Name = "uC_P_ViewMedicine1";
            this.uC_P_ViewMedicine1.Size = new System.Drawing.Size(1641, 1200);
            this.uC_P_ViewMedicine1.TabIndex = 2;
            // 
            // uC_P_AddMedicine1
            // 
            this.uC_P_AddMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_P_AddMedicine1.Location = new System.Drawing.Point(0, 1);
            this.uC_P_AddMedicine1.Name = "uC_P_AddMedicine1";
            this.uC_P_AddMedicine1.Size = new System.Drawing.Size(1094, 780);
            this.uC_P_AddMedicine1.TabIndex = 1;
            // 
            // uC_P_Dashboard1
            // 
            this.uC_P_Dashboard1.BackColor = System.Drawing.Color.White;
            this.uC_P_Dashboard1.Location = new System.Drawing.Point(-1, 2);
            this.uC_P_Dashboard1.Name = "uC_P_Dashboard1";
            this.uC_P_Dashboard1.Size = new System.Drawing.Size(1094, 780);
            this.uC_P_Dashboard1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel3;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel3;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel3;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.panel3;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.panel3;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.TargetControl = this.panel3;
            // 
            // uC_P_SellMedicines1
            // 
            this.uC_P_SellMedicines1.BackColor = System.Drawing.Color.White;
            this.uC_P_SellMedicines1.Location = new System.Drawing.Point(-2, 1);
            this.uC_P_SellMedicines1.Name = "uC_P_SellMedicines1";
            this.uC_P_SellMedicines1.Size = new System.Drawing.Size(1094, 780);
            this.uC_P_SellMedicines1.TabIndex = 5;
            // 
            // Pharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 780);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pharmacist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacist";
            this.Load += new System.EventHandler(this.Pharmacist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSellMedicine;
        private System.Windows.Forms.Button btnMedValCheck;
        private System.Windows.Forms.Button btnModifyMedicine;
        private System.Windows.Forms.Button btnViewMedicine;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private PharmacistUC.UC_P_Dashboard uC_P_Dashboard1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private PharmacistUC.UC_P_AddMedicine uC_P_AddMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private PharmacistUC.UC_P_ViewMedicine uC_P_ViewMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private PharmacistUC.UC_P_ModifyMedicine uC_P_ModifyMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private PharmacistUC.UC_P_MedValidityCheck uC_P_MedValidityCheck1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private PharmacistUC.UC_P_SellMedicines uC_P_SellMedicines1;
    }
}