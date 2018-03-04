using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLSACH
{
    class DataProvider
    {

        string chuoiKetNoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Window 10\source\repos\QLSACH\QLSACH\QLSACH.mdf;Integrated Security=True";
        public SqlConnection conn;
        public DataTable dt;

        public DataProvider()
        {
            conn = new SqlConnection(chuoiKetNoi);
        }

        public void Open()
        {
            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();
        }

        public void Close()
        {
            if (conn.State != System.Data.ConnectionState.Closed)
                conn.Close();
        }

        public int ExeNoQuery(string sql)
        {
            Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            int ketQua = comm.ExecuteNonQuery();
            Close();
            return ketQua;
        }

        public int ExeNoQuery(string sql,SqlParameter param)
        {
            Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.Add(param);
            int ketQua = comm.ExecuteNonQuery();
            Close();
            return ketQua;
        }

        public DataTable GetDataTable(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int ExeScalar(string sql)
        {
            Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            int ketQua = (int)comm.ExecuteScalar();
            Close();
            return ketQua;
        }
    }
}
