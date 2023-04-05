using Microsoft.Data.SqlClient;
using System.Data;

namespace HotelManagement
{
    internal class function
    {
        protected SqlConnection getConnection()
        {
            //string connectionString = "Data Source=<DESKTOP-3F1DCOU\\SQLEXPRESS>;Initial Catalog=hotel;Integrated Security=True";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-3F1DCOU\\SQLEXPRESS;Initial Catalog=HotelManagement;Integrated Security=True; TrustServerCertificate=True";
            return con;
        }

        public DataSet getData(String query) // get data from the database
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(String query,String message)
        { 
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("'" + message + "'", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public SqlDataReader getForCombo(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }      
    }
}
