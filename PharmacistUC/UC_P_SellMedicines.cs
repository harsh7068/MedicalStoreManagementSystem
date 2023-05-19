using DGVPrinterHelper;
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
    public partial class UC_P_SellMedicines : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        public UC_P_SellMedicines()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBoxMedicines.Items.Clear();
            query = "select mname from medicine where mname like '" + txtSearchBox.Text + "%' and eDate >= getdate() and quantity > '0'";
            ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if(txtQuantity.Text != "")
            {
                Int64 unitPrice = Int64.Parse(txtMedPerPrice.Text);
                Int64 noOfUnits = Int64.Parse(txtQuantity.Text);
                Int64 totalAmount = unitPrice * noOfUnits;
                txtTotalPrice.Text = totalAmount.ToString();
            }
            else
            {
                txtTotalPrice.Clear();
            }
        }

        private void UC_P_SellMedicines_Load(object sender, EventArgs e)
        {
            listBoxMedicines.Items.Clear();
            query = "select mname from medicine where eDate >= getdate() and quantity > '0'";
            ds = fn.getData(query);
            for(int i=0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_P_SellMedicines_Load(this, null);
        }

        private void listBoxMedicines_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuantity.Clear();
            String name = listBoxMedicines.GetItemText(listBoxMedicines.SelectedItem);
            txtMedName.Text = name;
            query = "select mid,eDate,perUnit from medicine where mname = '" + name + "'";
            ds = fn.getData(query);
            txtMedID.Text = ds.Tables[0].Rows[0][0].ToString();
            txtMedExp.Text = ds.Tables[0].Rows[0][1].ToString();
            txtMedPerPrice.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        protected int n, totalAmount = 0;
        protected Int64 quantity, newQuantity;

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if(txtMedID.Text != "")
            {
                query = "select quantity from medicine where mid = '" + txtMedID.Text + "'";
                ds = fn.getData(query);
                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                newQuantity = quantity - Int64.Parse(txtQuantity.Text);
                if(newQuantity >= 0)
                {
                    n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = txtMedID.Text;
                    dataGridView1.Rows[n].Cells[1].Value = txtMedName.Text;
                    dataGridView1.Rows[n].Cells[2].Value = txtMedExp.Text;
                    dataGridView1.Rows[n].Cells[3].Value = txtMedPerPrice.Text;
                    dataGridView1.Rows[n].Cells[4].Value = txtQuantity.Text;
                    dataGridView1.Rows[n].Cells[5].Value = txtTotalPrice.Text;
                    totalAmount = totalAmount + int.Parse(txtTotalPrice.Text);
                    lblTotalPrice.Text = "Rs. " + totalAmount.ToString();
                    query = "update medicine set quantity = '" + newQuantity + "' where mid = '" + txtMedID.Text + "'";
                    fn.setData(query, "Medicine Added!!!");
                }
                else
                {
                    MessageBox.Show("Medicine is out of stock!!!\n Only " + quantity + " left.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                clearAll();
                UC_P_SellMedicines_Load(this, null);
            }
            else
            {
                MessageBox.Show("Please select a medicine to add!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int valueAmount;
        String valueID;
        protected Int64 noOfUnits;

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfUnits = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch(Exception)
            {

            }
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "Medicine Bill";
            print.SubTitle = String.Format("Date:- {0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Total Payable Amount : " + lblTotalPrice.Text;
            print.FooterSpacing = 15;
            print.PrintDataGridView(dataGridView1);
            totalAmount = 0;
            lblTotalPrice.Text = "RS. 00";
            dataGridView1.DataSource = 0;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(valueID != null)
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                }
                catch
                {

                }
                finally
                {
                    query = "select quantity from medicine where mid = '" + valueID + "'";
                    ds = fn.getData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity + noOfUnits;
                    query = "update medicine set quantity = '" + newQuantity + "' where mid = '" + valueID + "'";
                    fn.setData(query, "Medicine removed!!!");
                    totalAmount = totalAmount - valueAmount;
                    lblTotalPrice.Text = "Rs. " + totalAmount.ToString();
                }
                UC_P_SellMedicines_Load(this, null);
            }
        }

        private void clearAll()
        {
            txtMedID.Clear();
            txtMedName.Clear();
            txtMedExp.ResetText();
            txtMedPerPrice.Clear();
            txtQuantity.Clear();
        }
    }
}
