using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Provider.Education
{
    using System.Data;
    using System.Data.SqlClient;

    public class Task : DBData, ITable
    {
        public override string TableName
        {
            get
            {
                return "Task";
            }
        }

        public DataTable GetByLesson(Guid lessonUid)
        {
            try
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = Connection;
                    comm.CommandText = "select * from " + TableName + " where LessonID = @LessonID";
                    comm.Parameters.AddWithValue("LessonID", lessonUid);
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
