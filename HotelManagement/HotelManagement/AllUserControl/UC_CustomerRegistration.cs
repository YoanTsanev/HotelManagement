using Microsoft.Data.SqlClient;
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
    public partial class UC_CustomerRegistration : UserControl
    {
        function fn = new function();
        String query;
        public UC_CustomerRegistration()
        {
            InitializeComponent();
        }

        public void setComboBox(String query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }
        private void UC_CustomerRegistration_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomNumber.Items.Clear();
            txtPrice.Clear();
            query = "select roomNo from rooms where bed = '" + txtBed.Text + "' and roomType= '" + txtRoomType.Text + "' and booked= 'Free'";
            setComboBox(query, txtRoomNumber);
        }

        private void txtBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomType.SelectedIndex = -1;
            txtRoomNumber.Items.Clear();
            txtPrice.Clear();
        }

        int rid;
        private void txtRoomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select price, roomId from rooms where roomNo = '" + txtRoomNumber.Text + "'";
            DataSet ds = fn.getData(query);
            txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());
        }

        private void btnReserveRoom_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtContact.Text != "" && txtNationality.Text != "" && txtGender.Text != "" && txtDateofBday.Text != "" && txtIdDoc.Text != "" && txtCheckIn.Text != "" && txtPrice.Text != "")
            {
                String name = txtName.Text;
                Int64 mobile = Int64.Parse(txtContact.Text);
                String nationality = txtNationality.Text;
                String gender = txtGender.Text;
                String dateofBday = txtDateofBday.Text;
                String idDoc = txtIdDoc.Text;
                String address = txtAddress.Text;
                String chechIn = txtCheckIn.Text;

                query = "insert into customer (custName, mobile, nationality, genter, dateOfBday, custIdDoc, custAddress, checkin, roomId) " +
                    "values ('" + name + "', '" + mobile + "', '" + nationality + "', '" + gender + "', '" + dateofBday + "', '" + idDoc + "', '" + address + "', '" + chechIn + "', " + rid + ")" +
                    "update rooms set booked = 'Occupied' " +
                    "where roomNo = '" + txtRoomNumber.Text + "'";

                fn.setData(query, "RoomNo " + txtRoomNumber.Text + " Reserved Successfully");
                clearAll();
            }
            else
            {
                MessageBox.Show("All the fields must be full!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void clearAll()
        {
            txtName.Clear();
            txtContact.Clear();
            txtNationality.Clear();
            txtGender.SelectedIndex = -1;
            txtDateofBday.ResetText();
            txtAddress.Clear();
            txtCheckIn.ResetText();
            txtBed.SelectedIndex = -1;
            txtRoomType.SelectedIndex = -1;
            txtRoomNumber.Items.Clear();
            txtPrice.Clear();
            txtIdDoc.Clear();
        }

        private void btnReserveRoom_Leave(object sender, EventArgs e)
        {

        }

        private void UC_CustomerRegistration_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
