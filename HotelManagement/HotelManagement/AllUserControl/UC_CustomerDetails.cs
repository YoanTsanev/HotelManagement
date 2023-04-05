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
    public partial class UC_CustomerDetails : UserControl
    {
        function fn = new function();
        String query;
        public UC_CustomerDetails()
        {
            InitializeComponent();
        }

        private void UC_CustomerDetails_Load(object sender, EventArgs e)
        {
            //txtSearchBy.SelectedIndex = 0;
            //query = "select customer.custName, customer.mobile, customer.nationality, customer.genter, customer.dateOfBday, customer.custIdDoc, customer.custAddress, customer.checkin, customer.checkout, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price from customer inner join rooms on customer.roomId = rooms.roomId where checkout is null";
            // DataSet ds = fn.getData(query);
            //guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSearchBy.SelectedIndex == 0)
            {
                query = "select customer.custName, customer.mobile, customer.nationality, customer.genter, customer.dateOfBday, customer.custIdDoc, customer.custAddress, customer.checkin, customer.checkout, rooms.roomNo, rooms.price, rooms.bed, customer.totalFee from customer inner join rooms on customer.roomId = rooms.roomId ";
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else if (txtSearchBy.SelectedIndex == 1)
            {
                query = "select customer.custName, customer.mobile, customer.nationality, customer.genter, customer.dateOfBday, customer.custIdDoc, customer.custAddress, customer.checkin, customer.checkout, rooms.roomNo, rooms.price, rooms.bed, customer.totalFee from customer inner join rooms on customer.roomId = rooms.roomId where checkout is null";
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else if (txtSearchBy.SelectedIndex == 2)
            {
                query = "select customer.custName, customer.mobile, customer.nationality, customer.genter, customer.dateOfBday, customer.custIdDoc, customer.custAddress, customer.checkin, customer.checkout, rooms.roomNo, rooms.price, rooms.bed, customer.totalFee from customer inner join rooms on customer.roomId = rooms.roomId where checkout is not null ";
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void UC_CustomerDetails_MouseMove(object sender, MouseEventArgs e)
        {
            UC_CustomerDetails_Load(this, null);
        }

        private void UC_CustomerDetails_MouseClick(object sender, MouseEventArgs e)
        {
            UC_CustomerDetails_Load(this, null);
        }
    }
}
