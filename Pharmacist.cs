using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Store_Management_System
{
    public partial class Pharmacist : Form
    {
        public Pharmacist()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uC_P_Dashboard1.Visible = true;
            uC_P_Dashboard1.BringToFront();
        }

        private void Pharmacist_Load(object sender, EventArgs e)
        {
            uC_P_Dashboard1.Visible = false;
            btnDashboard.PerformClick();
            uC_P_AddMedicine1.Visible = false;
            uC_P_ViewMedicine1.Visible = false;
            uC_P_ModifyMedicine1.Visible = false;
            uC_P_MedValidityCheck1.Visible = false;
            uC_P_SellMedicines1.Visible = false;
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            uC_P_AddMedicine1.Visible = true;
            uC_P_AddMedicine1.BringToFront();
        }

        private void btnViewMedicine_Click(object sender, EventArgs e)
        {
            uC_P_ViewMedicine1.Visible = true;
            uC_P_ViewMedicine1.BringToFront();
        }

        private void btnModifyMedicine_Click(object sender, EventArgs e)
        {
            uC_P_ModifyMedicine1.Visible = true;
            uC_P_ModifyMedicine1.BringToFront();
        }

        private void btnMedValCheck_Click(object sender, EventArgs e)
        {
            uC_P_MedValidityCheck1.Visible = true;
            uC_P_MedValidityCheck1.BringToFront();
        }

        private void btnSellMedicine_Click(object sender, EventArgs e)
        {
            uC_P_SellMedicines1.Visible = true;
            uC_P_SellMedicines1.BringToFront();
        }
    }
}
