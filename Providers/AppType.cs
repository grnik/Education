using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Providers
{
    using System.Data;

    class AppType : IAppType
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ITable GetById(Guid id)
        {
            DataAccess.Education.Lesson lesson = new DataAccess.Education.Lesson();

            DataRow row = lesson.GetByID(id);

            return DataToClass(row);
        }

        public List<ITable> GetAll()
        {
            List<AppType> listAppType = new List<AppType>();

            DataAccess.Education.Lesson lesson = new DataAccess.Education.Lesson();

            DataTable lessons = lesson.GetAll();
            foreach (var elem in lessons)
            {
                listAppType.Add(DataToClass(elem));
            }

            return listAppType;
        }

        private AppType DataToClass(DataRow row)
        {
            AppType newElem = new AppType();

            newElem.Id = new Guid(row["Id"].ToString());
            newElem.Name = row["Name"].ToString();

            return newElem;
        }
    }
}
