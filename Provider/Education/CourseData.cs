using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataAccess
{
    using DataAccess;

    public class CourseData : DBData
    {
        public override string TableName
        {
            get
            {
                return "Course";
            }
        }

        public bool AddRow(string name)
        {
            DataRow newRow = this.NewRow();

            newRow["ID"] = Guid.NewGuid();
            newRow["Name"] = name;

            return AddRow(newRow);
        }
    }
}
