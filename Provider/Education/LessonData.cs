using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    using System.Data;

    public class LessonData : DBData
    {
        public DataTable GetByCourse(Guid courseId)
        {
            try
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = Connection;
                    comm.CommandText = "select * from " + TableName + " where CourseID = @CourseID";
                    comm.Parameters.AddWithValue("CourseID", courseId);
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

        public override string TableName
        {
            get
            {
                return "Lesson";
            }
        }

        public bool AddRow(string name, string description, byte[] fileApp, Guid appTypeId, Guid courseId, int lessonOrder)
        {
            DataRow newRow = this.NewRow();

            newRow["ID"] = Guid.NewGuid();
            newRow["Name"] = name;
            newRow["Description"] = description;
            newRow["App"] = fileApp;
            newRow["AppTypeID"] = appTypeId;
            newRow["CourseID"] = courseId;
            newRow["LessonOrder"] = lessonOrder;

            return AddRow(newRow);
        }
    }
}
