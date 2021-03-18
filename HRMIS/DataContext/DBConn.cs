using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace HRMIS.DataContext
{
	public class DBConn
	{

        public static string ConnectionString { get; set; }
    }


    public class DbCon
    {
        public static IDbConnection Connection()
        {
            IDbConnection _db = new SqlConnection(DBConn.ConnectionString);

            return _db;
        }
    }
}
