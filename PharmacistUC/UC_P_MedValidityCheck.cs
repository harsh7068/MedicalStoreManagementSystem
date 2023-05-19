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
    public partial class UC_P_MedValidityCheck : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        public UC_P_MedValidityCheck()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                query = "select * from medicine where eDate >= getdate()";
                setDataGridView(query, "Valid Medicines", Color.Green);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                query = "select * from medicine where eDate <= getdate()";
                setDataGridView(query, "Expired Medicines", Color.Red);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                query = "select * from medicine";
                setDataGridView(query, "", Color.Black);
            }
        }

        private void setDataGridView(String query, String lblName, Color col)
        {
            ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            txtLbl.Text = lblName;
            txtLbl.ForeColor = col;
        }

        private void UC_P_MedValidityCheck_Load(object sender, EventArgs e)
        {
            txtLbl.Text = "";
        }
    }
}
