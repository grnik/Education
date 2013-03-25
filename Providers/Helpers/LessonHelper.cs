using System;
using System.Collections.Generic;
using System.Data;
using DataAccess.Education;

namespace Providers
{

    public class LessonHelper
    {
        public static Lesson GetById(Guid id)
        {
            LessonData data = new LessonData();

            return Translate(data.GetByID(id));
        }

        public static List<Lesson> GetAll()
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

        public static void Save(Lesson lesson)
        {
            LessonData data = new LessonData();

            if(lesson.ID == Guid.Empty)
            {
                lesson.ID = Guid.NewGuid();
                data.AddRow(lesson.Name, lesson.Description, lesson.App, lesson.AppType.ID);
            }
            else
            {
                DataRow row = data.GetByID(lesson.ID);

                row["Name"] = lesson.Name;
                row["Description"] = lesson.Description;
                row["App"] = lesson.App;
                row["AppTypeID"] = lesson.AppType.ID;

                data.Save();
            }
        }

        static Lesson Translate(DataRow data)
        {
            Lesson newLesson = new Lesson();

            newLesson.ID = (Guid)(data["ID"]);
            newLesson.Name = data["Name"].ToString();
            newLesson.Description = data["Description"].ToString();
            if(data["App"] != DBNull.Value)
                newLesson.App = (byte[])data["App"];
            newLesson.AppType = AppTypeHelper.GetById((Guid)(data["AppTypeID"]));

            return newLesson;
        }
    }
}
