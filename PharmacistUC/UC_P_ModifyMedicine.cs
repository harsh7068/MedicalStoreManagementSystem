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
    public partial class UC_P_ModifyMedicine : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        public UC_P_ModifyMedicine()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        Int64 totalQuanity;

        private void btnModifyMed_Click(object sender, EventArgs e)
        {
            String mname = txtMedName.Text;
            String nmunber = txtMedNum.Text;
            String mdate = txtMedMfg.Text;
            String edate = txtMedExp.Text;
            Int64 avblQuantity = Int64.Parse(txtMedAvblQuantity.Text);
            Int64 addQuantity = Int64.Parse(txtAddMedQuantity.Text);
            totalQuanity = avblQuantity + addQuantity;
            Int64 price = Int64.Parse(txtMedPrice.Text);

            query = "update medicine set mname= '" + mname + "',mnumber = '" + nmunber + "',mDate = '" + mdate + "',eDate = '" + edate + "',quantity = " + totalQuanity + ",perUnit = " + price + " where mid = '" + txtMedID.Text + "'";
            fn.setData(query, "Medicine Updated!!!");
            clearAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtMedID.Text != "")
            {
                query = "select * from medicine where mid = '" + txtMedID.Text + "'";
                ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtMedName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtMedNum.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtMedMfg.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtMedExp.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtMedAvblQuantity.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtMedPrice.Text = ds.Tables[0].Rows[0][7].ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a valid medicine ID!!!" + txtMedID.Text + "does not exists." ,"Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                clearAll();
            }
        }

        public void clearAll()
        {
            txtMedID.Clear();
            txtMedName.Clear();
            txtMedNum.Clear();
            txtMedMfg.ResetText();
            txtMedExp.ResetText();
            txtMedAvblQuantity.Clear();
            txtMedPrice.Clear();
            txtAddMedQuantity.Text = "0";
        }
    }
}
