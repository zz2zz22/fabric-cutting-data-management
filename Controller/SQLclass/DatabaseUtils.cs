using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cloth_cutting_data_report
{
    public class DatabaseUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = "172.16.0.12";
            string database = "VUSOFT_SUPPORT";
            string username = "ERPUSER";
            string password = "12345";
            return DatabaseSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
        public static SqlConnection GetHRDATAConnection()
        {
            string datasource = "172.16.0.9\\tx";
            string database = "txcard";
            string username = "sa";
            string password = "ppnn13";
            return DatabaseSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }
}
