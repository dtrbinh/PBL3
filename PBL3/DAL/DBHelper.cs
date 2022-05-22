using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAL
{
    class DBHelper
    {
        private static DBHelper _Instance;
        public static DBHelper Instance
        {
            get
            {
                if (_Instance == null)
                {
                    string s = @"Data Source=CATCH-ME; Initial Catalog=QUANLYSINHVIEN; Integrated Security=True";
                    _Instance = new DBHelper(s);
                }
                return _Instance;
            }
            private set { }
        }
        private SqlConnection cnn;
        public DBHelper(string s)
        {
            cnn = new SqlConnection(s);
        }
        public void ExecuteDB(string query)
        {
            SqlCommand cmd = new SqlCommand(query, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public DataTable GetRecords(string query)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
    }
}
