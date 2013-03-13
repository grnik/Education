using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Provider.Education
{
    using System.Data;

    public class Lesson
    {
        DBData db = new DBData();
        
        public const string TableName = "Lesson";

        /// <summary>
        /// Вернуть список всех уроков.
        /// </summary>
        public DataTable All()
        {
            try
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = db.connection;
                    comm.CommandText = "select * from Lesson";

                }
            }
            catch (Exception)
            {
                return new DataTable(TableName);
            }
        }
    }
}
