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
    public partial class UC_P_ViewMedicine : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        public UC_P_ViewMedicine()
        {
            InitializeComponent();
        }

        private void UC_P_ViewMedicine_Load(object sender, EventArgs e)
        {
            query = "select * from medicine";
            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtMedName_TextChanged(object sender, EventArgs e)
        {
            query = "select * from medicine where mname like '" + txtMedName.Text + "%'";
            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_P_ViewMedicine_Load(this, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete confirmation!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from medicine where mid = '" + medID + "'";
                fn.setData(query, "Medicine Deleted!!!");
                UC_P_ViewMedicine_Load(this, null);
            }
            else
            {
                MessageBox.Show("No medicine selected!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        String medID;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medID = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
