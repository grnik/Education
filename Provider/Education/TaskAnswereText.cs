using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Education
{
    using System.Data;

    class TaskAnswereText : DBData
    {
        public override string TableName
        {
            get
            {
                return "TaskAnswereText";
            }
        }

        public DataRow GetByTaskAnswere(Guid uid)
        {
            return this.GetByID(uid);
        }
    }
}
