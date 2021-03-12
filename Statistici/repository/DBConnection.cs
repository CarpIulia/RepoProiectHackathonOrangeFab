using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistici
{
    class DBConnection
    {
        public SqlConnection sqlConnection;
        private string connectionStr;

        public DBConnection(string connectionStr)
        {
            this.connectionStr = connectionStr;
        }

        public void connect()
        {
            sqlConnection = new SqlConnection(connectionStr);
            sqlConnection.Open();
        }
    }
}
