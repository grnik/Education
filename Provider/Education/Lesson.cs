using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Education
{
    using System.Data;

    public class Lesson : DBData
    {
        public override string TableName
        {
            get
            {
                return "Lesson";
            }
        }

        public bool AddRow(string name, string description, string fileApp, AppType type)
        {
            DataRow newRow = this.NewRow();

            newRow["ID"] = Guid.NewGuid();
            newRow["Name"] = name;
            newRow["Description"] = description;
            newRow["App"] = FileToByte(fileApp);
            newRow["AppTypeID"] = type.ID;

            return AddRow(newRow);
        }
    }
}
