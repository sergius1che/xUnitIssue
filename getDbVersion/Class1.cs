using System;
using System.Data.SqlClient;
using Dapper;
using System.Linq;

namespace getDbVersion
{
    public class Class1
    {
        public string GetDbVersion(string connStr)
        {
            using (SqlConnection dbConnection = new SqlConnection(connStr))
            {
                dbConnection.Open();
                return dbConnection.Query<string>("SELECT @@VERSION", commandTimeout: 600).Single();
            }
        }
    }
}
