using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.AllUserControl
{
    public partial class UC_Employee : UserControl
    {
        function fn = new function();
        String query;
        public UC_Employee()
        {
            InitializeComponent();

            setEmployeePuplic(guna2DataGridView1);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            getMaxID();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtMobile.Text != "" && txtGender.Text != "" && txtEmail.Text != "" && txtUserName.Text != "" && txtPassword.Text != "")
            {
                String name = txtName.Text;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String gender = txtGender.Text;
                String email = txtEmail.Text;
                String userName = txtUserName.Text;
                String password = txtPassword.Text;

                query = "insert into employee (emplName, modbile, gender, email, username, password)" +
                    "values ('" + name + "', '" + mobile + "', '" + gender + "', '" + email + "', '" + userName + "', '" + password + "')";
                fn.setData(query, "Employee Creaded Succssefully!");

                clearAll();
                getMaxID();
            }
            else
            {
                MessageBox.Show("All Fields must be full!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void getMaxID()
        {
            query = "select max(emplId) from employee";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows[0][0].ToString() != null)
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

                labelToSet.Text = (num + 1).ToString();
            }
        }

        public void clearAll()
        {
            txtName.Clear();
            txtMobile.Clear();
            txtEmail.Clear();
            txtGender.SelectedIndex = -1;
            txtUserName.Clear();
            txtPassword.Clear();
        }
        public void setEmployeePuplic(DataGridView dvg)
        {
            query = "select emplId, emplName, modbile, email, username from employee";
            DataSet ds = fn.getData(query);
            dvg.DataSource = ds.Tables[0];
        }
        public void setEmployee(DataGridView dvg)
        {
            query = "select * from employee";
            DataSet ds = fn.getData(query);
            dvg.DataSource = ds.Tables[0];
        }

        private void tabEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabEmployee.SelectedIndex == 1)
            {
                // admin password
                string adminPassword = Prompt.ShowDialog("Enter admin password:", "Admin Login");

                
                if (adminPassword == "admin123")
                {
                    // If the password is correct, show the tab
                    setEmployeePuplic(guna2DataGridView1);
                }
                else
                {
                    // If the password is incorrect, go back to the first tab
                    tabEmployee.SelectedIndex = 0;
                }
            }
            else if (tabEmployee.SelectedIndex == 2)
            {
                
                string adminPassword = Prompt.ShowDialog("Enter admin password:", "Admin Login");

               
                if (adminPassword == "admin123")
                {                    
                    setEmployee(guna2DataGridView2);
                }
                else
                {                    
                    tabEmployee.SelectedIndex = 0;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDelete.Text != "")
            {
                if (MessageBox.Show("Are you sure?", "Confirmation.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    query = "delete from employee where emplId = " + txtDelete.Text + " ";
                    fn.setData(query, "Emloyee Deleted Successfully!");
                    tabEmployee_SelectedIndexChanged(this, null);
                }                
            }
            else
            {
                MessageBox.Show("Enter ID Number to be Deleted!", "Input Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void UC_Employee_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form()
                {
                    Width = 500,
                    Height = 150,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };
                Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
                TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400, PasswordChar = '*' };
                Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
            }
        }

        private void UC_Employee_MouseClick(object sender, MouseEventArgs e)
        {
            UC_Employee_Load(this, null);
        }
    }
}
