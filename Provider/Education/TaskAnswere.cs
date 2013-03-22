using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Education
{
    public class TaskAnswere : DBData
    {
        public override string TableName
        {
            get
            {
                return "TaskAnswere";
            }
        }

        public DataTable GetByTask(Guid taskUid)
        {
            try
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = Connection;
                    comm.CommandText = "select * from " + TableName + " where TaskID = @TaskID";
                    comm.Parameters.AddWithValue("TaskID", taskUid);
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    DataSet data = new DataSet();
                    adapter.Fill(data, TableName);

                    return data.Tables[TableName];
                }
            }
            catch (Exception)
            {
                return new DataTable(TableName);
            }
        }
    }
}
