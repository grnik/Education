using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccess.Education;

namespace Providers
{

    public static class AppTypeHelper
    {
        public static AppType GetById(Guid id)
        {
            AppTypeData data = new AppTypeData();

            return Translate(data.GetByID(id));
        }

        public static List<AppType> GetAll()
        {
            AppTypeData data = new AppTypeData();

            List<AppType> list = new List<AppType>();

            DataTable table = data.GetAll();
            foreach (DataRow row in table.Rows)
            {
                list.Add(Translate(row));
            }
            return list;
        }

        static AppType Translate(DataRow data)
        {
            AppType newAppType = new AppType();

            newAppType.ID = (Guid)(data["ID"]);
            newAppType.Name = data["Name"].ToString();

            return newAppType;
        }
    }
}
