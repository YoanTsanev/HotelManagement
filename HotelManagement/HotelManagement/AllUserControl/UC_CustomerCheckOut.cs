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
    public partial class UC_CustomerCheckOut : UserControl
    {
        function fn = new function();
        String query;
        public UC_CustomerCheckOut()
        {
            InitializeComponent();
        }

        private void UC_CustomerCheckOut_Load(object sender, EventArgs e)
        {
            query = "select rooms.roomNo, customer.custName, customer.mobile, customer.nationality, customer.genter, customer.dateOfBday, customer.custIdDoc, customer.custAddress, customer.checkin, rooms.bed, rooms.price from customer inner join rooms on customer.roomId = rooms.roomId where custStatus = 'Current'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
            query = "select customer.custId, customer.custName, customer.mobile, customer.nationality, customer.genter, customer.dateOfBday, customer.custIdDoc, customer.custAddress, customer.checkin, rooms.roomId, rooms.bed, rooms.price from customer inner join rooms on customer.roomId = rooms.roomId where custStatus = 'Current'";
            DataSet ds1 = fn.getData(query);
            guna2DataGridView2.DataSource = ds1.Tables[0];

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = "select rooms.roomNo, customer.custName, customer.mobile, customer.nationality, customer.genter, customer.dateOfBday, customer.custIdDoc, customer.custAddress, customer.checkin, rooms.bed, rooms.price from customer inner join rooms on customer.roomId = rooms.roomId where custName like '" + txtName.Text + "%' and custStatus = 'Current'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        int id;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(guna2DataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtCName.Text = guna2DataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoom.Text = guna2DataGridView2.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
        }


        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (txtCName.Text != "")
            {
                if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    String cdate = txtCheckOut.Text;
                    DateTime checkoutDate = DateTime.Parse(cdate);

                    // get the checkin date from the database
                    query = "SELECT checkin FROM customer WHERE custId = " + id;
                    DataSet ds = fn.getData(query);
                    DateTime checkinDate = DateTime.Parse(ds.Tables[0].Rows[0][0].ToString());

                    // calculate the number of days stayed
                    int numDays = (int)(checkoutDate - checkinDate).TotalDays;

                    // get the price per night for the selected room
                    query = "SELECT price FROM rooms INNER JOIN customer ON rooms.roomId = customer.roomId WHERE customer.custId = " + id;
                    ds = fn.getData(query);
                    int pricePerNight = int.Parse(ds.Tables[0].Rows[0][0].ToString());

                    // calculate the total fee
                    int totalFee = numDays * pricePerNight;

                    // update the database
                    query = "UPDATE customer SET custStatus = 'Former', checkout = '" + cdate + "', totalFee = " + totalFee + " WHERE custId = " + id + "; " +
                            "UPDATE rooms SET booked = 'Free' WHERE roomId = '" + txtRoom.Text + "'";
                    fn.setData(query, "Check Out was Successful!");

                    // display the total fee in a message box
                    MessageBox.Show("Total fee: " + totalFee, "Check Out was Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UC_CustomerCheckOut_Load(this, null);
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("Select a Customer!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void clearAll()
        {
            txtCName.Clear();
            txtName.Clear();
            txtRoom.Clear();
            txtCheckOut.ResetText();
        }

        private void UC_CustomerCheckOut_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_CustomerCheckOut_MouseClick(object sender, MouseEventArgs e)
        {
            UC_CustomerCheckOut_Load(this, null);
        }

        private void UC_CustomerCheckOut_MouseMove(object sender, MouseEventArgs e)
        {
            //UC_CustomerCheckOut_Load(this, null);
        }
    }
}
