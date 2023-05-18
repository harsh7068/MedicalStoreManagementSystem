using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Store_Management_System.PharmacistUC
{
    public partial class UC_P_AddMedicine : UserControl
    {
        function fn = new function();
        String query;
        public UC_P_AddMedicine()
        {
            InitializeComponent();
        }

        private void btnAddMed_Click(object sender, EventArgs e)
        {
            if(txtMedID.Text != "" && txtMedName.Text != "" && txtMedNum.Text != "" && txtMedQuantity.Text != "" && txtMedPrice.Text != "")
            {
                String mid = txtMedID.Text;
                String mname = txtMedName.Text;
                String mdate = txtMedMfg.Text;
                String edate = txtMedExp.Text;
                String  mnumber = txtMedNum.Text;
                Int64 quantity = Int64.Parse(txtMedQuantity.Text);
                Int64 price = Int64.Parse(txtMedPrice.Text);

                query = "insert into medicine(mid,mname,mnumber,mDate,eDate,quantity,perUnit)values('" + mid + "', '" + mname + "', '" + mnumber + "', '" + mdate + "', '" + edate + "', " + quantity + ", " + price + ")";
                fn.setData(query, "Medicine Added!!!");
                clearAll();
            }
            else
            {
                MessageBox.Show("Please fill add details!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtMedID.Clear();
            txtMedName.Clear();
            txtMedNum.Clear();
            txtMedQuantity.Clear();
            txtMedPrice.Clear();
            txtMedMfg.ResetText();
            txtMedExp.ResetText();
        }
    }
}
