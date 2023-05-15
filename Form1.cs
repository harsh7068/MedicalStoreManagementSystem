using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Store_Management_System
{
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            query = "select * from users";
            ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                if (txtUserName.Text == "root" && txtPassword.Text == "root")
                {
                    Administrator admin = new Administrator();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("You already have registered users, please login using that username and password!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                query = "select * from users where username = '" + txtUserName.Text + "' and pass = '" + txtPassword.Text + "'";
                ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    String role = ds.Tables[0].Rows[0][1].ToString();
                    if(role == "Administrator")
                    {
                        Administrator admin = new Administrator();
                        admin.Show();
                        this.Hide();
                    }
                    else if(role == "Pharmacist")
                    {
                        Pharmacist pharma = new Pharmacist();
                        pharma.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong username aur password!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //if(txtUserName.Text == "shubham" && txtPassword.Text == "pass")
            //{
            //    Administrator am = new Administrator();
            //    am.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Wrong UserName or Password!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
