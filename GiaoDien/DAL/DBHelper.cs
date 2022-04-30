using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GiaoDien.DAL
{
    public class DBHelper
    {
        private static DBHelper _Instance;
        private SqlConnection cnn;
        private DBHelper(string s)
        {
            cnn = new SqlConnection(s);
        }
        public static DBHelper Instance
        {
            get
            {
                if (_Instance == null)
                {
                    string cnnstr = @"Data Source=DESKTOP-1GG0LVP\SQLEXPRESS;Initial Catalog=STMN;Integrated Security=True";
                    _Instance = new DBHelper(cnnstr);
                }
                return _Instance;
            }
            private set { }
        }
        public DataTable GetRecord(string query)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;

        }
        public void ExcuteDB(string query)
        {
            SqlCommand cmd = new SqlCommand(query, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
