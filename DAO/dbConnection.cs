using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class dbConnection
    {
        SqlConnection con = new SqlConnection();
        public void conect()
        {
            string ServerName = @"BKL-NITRO5\BKL0306191434";            
            con.ConnectionString = @"data source=" + ServerName + ";initial catalog=QLY_BAN_HANG_LINH_KIEN;integrated security=true";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void disconnect()
        {
            con.Close();
        }

        public dbConnection()
        {
            conect();
        }
        public DataSet getData(String sqlQuerry)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            DataSet dataSet = new DataSet();
            SqlDataAdapter data = new SqlDataAdapter(sqlQuerry, con);
            data.Fill(dataSet);
            disconnect();
            return dataSet;
        }
        /// <summary>
        /// Cập nhật dữ liệu
        /// Xoá dữ liệu
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>Trả về numberRowsEffected</returns>
        public int updateData(String sql)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            
            int numberRowsEffected = cmd.ExecuteNonQuery();
            disconnect();
            
            return numberRowsEffected;
        }

        public int validateData(String sql)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            int numberRowsEffected = cmd.ExecuteNonQuery();
            disconnect();

            return numberRowsEffected;
        }
    }
}
