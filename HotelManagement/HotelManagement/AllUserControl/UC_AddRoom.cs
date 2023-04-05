using System.Data;


namespace HotelManagement.AllUserControl
{
    public partial class UC_AddRoom : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            try
            {
                query = "select roomNo, roomType, bed, price, booked from rooms";
                //SqlDataAdapter adapter = new SqlDataAdapter(query, "Data Source=<DESKTOP-3F1DCOU\\SQLEXPRESS>;Initial Catalog=hotel;Integrated Security=True");
                DataSet dataSet = new DataSet();
                DataSet ds = fn.getData(query);
                DataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (txtRoomNumber.Text != "" && txtType.Text != "" && txtRoomNumber.Text != "" && txtPrice.Text != "")
            {
                String roomNo = txtRoomNumber.Text;
                String type = txtType.Text;
                String bed = txtBeds.Text;
                Int64 price = Int64.Parse(txtPrice.Text);

                query = "insert into rooms (roomNo, roomType, bed, price)" +
                    "values ('" + roomNo + "', '" + type + "', '" + bed + "', '" + price + "')";
                fn.setData(query, "Room Added!");

                UC_AddRoom_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("Fill All Fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void clearAll()
        {
            txtRoomNumber.Clear();
            txtType.SelectedIndex = -1;
            txtBeds.SelectedIndex = -1;
            txtPrice.Clear();

        }

        private void UC_AddRoom_Enter(object sender, EventArgs e)
        {
            UC_AddRoom_Load(this, null);
        }

        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            clearAll();
            UC_AddRoom_Load(this, null);
        }

        private void UC_AddRoom_MouseClick(object sender, MouseEventArgs e)
        {
            UC_AddRoom_Load(this, null);
        }

        private void UC_AddRoom_MouseMove(object sender, MouseEventArgs e)
        {
            UC_AddRoom_Load(this, null);
        }
    }
}
