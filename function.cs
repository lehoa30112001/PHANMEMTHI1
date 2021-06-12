using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PHANMEMTHI
{
    class function
    {

        public static string ConnectionString = @"Data Source=DESKTOP-S4GU3GQ\SQLEXPRESS;Initial Catalog=phanmemthi;Integrated Security=True";

        protected SqlConnection getconnect()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnectionString;
            return conn; 
        }
        
        public DataTable getdt(String query)
        {
            SqlConnection conn = getconnect();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt; 
        }

        public void setdata(String query)
        {
            SqlConnection conn = getconnect();
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
