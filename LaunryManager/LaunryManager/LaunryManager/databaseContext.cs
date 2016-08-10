using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunryManager
{
    class databaseContext
    {
        public SqlConnection getConnection()
        {
            String str = "server=DESKTOP-LVBRFF7;database=LaundryDB;UID=sa;password=sa123";
            SqlConnection con = new SqlConnection(str);
            return con;
        }
    }
}
