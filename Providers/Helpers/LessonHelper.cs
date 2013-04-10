using System;
using System.Collections.Generic;
using System.Data;
using DataAccess;

namespace Providers
{

    public class LessonHelper : IModelHelper<Lesson>
    {
        static AppTypeHelper appTypeHelper = new AppTypeHelper();
        static CourseHelper courseHelper = new CourseHelper();

        public Lesson GetById(Guid id)
        {
            LessonData data = new LessonData();

            return Translate(data.GetByID(id));
        }

        public List<Lesson> GetByCourse(Guid courseId)
        {
            LessonData data = new LessonData();

            List<Lesson> list = new List<Lesson>();

            DataTable table = data.GetByCourse(courseId);
            foreach (DataRow row in table.Rows)
            {
                list.Add(Translate(row));
            }
            return list;
        }

        public List<Lesson> GetAll()
        {
            LessonData data = new LessonData();

            List<Lesson> list = new List<Lesson>();

            DataTable table = data.GetAll();
            foreach (DataRow row in table.Rows)
            {
                list.Add(Translate(row));
            }
            return list;
        }

        public void Save(Lesson elem)
        {
            LessonData data = new LessonData();

            if (elem.ID == Guid.Empty)
            {
                elem.ID = Guid.NewGuid();
                data.AddRow(elem.Name, elem.Description, elem.App, elem.AppType.ID, elem.Course.ID, elem.Order);
            }
            else
            {
                DataRow row = data.GetByID(elem.ID);

                row["Name"] = elem.Name;
                row["Description"] = elem.Description;
                row["App"] = elem.App;
                if (elem.AppType == null)
                    row["AppTypeID"] = DBNull.Value;
                else
                    row["AppTypeID"] = elem.AppType.ID;
                //row["AppTypeID"] = AppTypeData.AppTypeDataText.ID;
                data.Save();
            }
        }

        Lesson Translate(DataRow data)
        {
            Lesson newLesson = new Lesson();

            newLesson.ID = (Guid)(data["ID"]);
            newLesson.Name = data["Name"].ToString();
            newLesson.Description = data["Description"].ToString();
            if (data["App"] != DBNull.Value)
                newLesson.App = (byte[])data["App"];
            newLesson.AppType = appTypeHelper.GetById((Guid)(data["AppTypeID"]));
            newLesson.Course = courseHelper.GetById((Guid)(data["CourseID"]));

            return newLesson;
        }
    }
}
