using System;
using System.Collections.Generic;
using System.Data;
using DataAccess;

namespace Providers
{

    public class TaskHelper
    {
        public static Task GetById(Guid id)
        {
            TaskData data = new TaskData();

            return Translate(data.GetByID(id));
        }

        public static List<Task> GetByLesson(Lesson lesson)
        {
            TaskData data = new TaskData();

            List<Task> list = new List<Task>();

            DataTable table = data.GetByLesson(lesson.ID);
            foreach (DataRow row in table.Rows)
            {
                list.Add(Translate(row));
            }
            return list;
        }

        public static List<Task> GetAll()
        {
            TaskData data = new TaskData();

            List<Task> list = new List<Task>();

            DataTable table = data.GetAll();
            foreach (DataRow row in table.Rows)
            {
                list.Add(Translate(row));
            }
            return list;
        }

        static Task Translate(DataRow data)
        {
            Task newTask = new Task();

            newTask.ID = (Guid)(data["ID"]);
            newTask.Lesson = LessonHelper.GetById((Guid)data["LessonID"]);
            newTask.TaskString = data["Task"].ToString();
            if (data["App"] != DBNull.Value)
                newTask.App = (byte[])data["App"];
            newTask.AppType = AppTypeHelper.GetById((Guid)(data["AppTypeID"]));
            newTask.TaskOrder = (int)data["TaskOrder"];

            return newTask;
        }
    }
}
