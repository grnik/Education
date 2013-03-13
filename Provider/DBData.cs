using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Provider
{
    internal class DBData
    {
        private const string ConnectionString = @"Data Source=C0009;Initial Catalog=Education;Integrated Security=True";

        public SqlConnection connection { get; private set; }
        
        public DBData()
        {
            connection = new SqlConnection(ConnectionString);
        }
    }
}
