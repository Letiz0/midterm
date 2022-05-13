using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace midterm_project
{
    class Sql
    {
        static SqlConnectionStringBuilder scsb;
        static string connect;
        public static SqlConnection con;

        public static void Connect()
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.InitialCatalog = "midterm_project";
            scsb.DataSource = ".";
            scsb.IntegratedSecurity = true;
            connect = scsb.ToString();
            con = new SqlConnection(connect);
            con.Open();
        }        
    }
}
