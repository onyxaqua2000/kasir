using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UTS_BASIS_DATA
{
    class koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection conn = new SqlConnection ();
            conn.ConnectionString = "Data Source=DESKTOP-09067HR;Initial Catalog=dbabsensi;Integrated Security=True";
            return conn; 
        }

    }
}
