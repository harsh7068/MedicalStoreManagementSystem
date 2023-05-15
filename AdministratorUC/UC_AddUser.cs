using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Store_Management_System.AdministratorUC
{
    public partial class UC_AddUser : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void UC_AddUser_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            String role = txtUserRole.Text;
            String name = txtUserName.Text;
            String dob = txtUserDOB.Text;
            Int64 mobile = Int64.Parse(txtUserMob.Text);
            String email= txtUserEmail.Text;
            String username = txtUserUsername.Text;
            String password = txtUserPassword.Text;
            try
            {
                query = "insert into users(userRole, name, dob, mobile, email, username, pass)values('" + role + "', '" + name + "', '" + dob + "', " + mobile + ", '" + email + "', '" + username + "', '" + password + "')";
                fn.setData(query, "User Inserted!!!");
                clearAll();
            }
            catch(Exception)
            {
                MessageBox.Show("Username Allready exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void btnUserReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtUserRole.SelectedIndex = -1;
            txtUserName.Clear();
            txtUserDOB.ResetText();
            txtUserMob.Clear();
            txtUserEmail.Clear();
            txtUserUsername.Clear();
            txtUserPassword.Clear();
        }

        private void txtUserUsername_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username = '" + txtUserUsername.Text + "'";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                pictureBox1.ImageLocation = @"C:\Users\HERO\Source\Repos\MedicalStoreManagementSystem\Resources\yes.png";
            }
            else
            {
                pictureBox1.ImageLocation = @"C:\Users\HERO\Source\Repos\MedicalStoreManagementSystem\Resources\no.png";
            }
        }
    }
}
