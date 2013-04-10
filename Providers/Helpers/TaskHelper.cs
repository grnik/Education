using System;
using System.Collections.Generic;
using System.Data;
using DataAccess;

namespace Providers
{

    public class TaskHelper : IModelHelper<Task>
    {
        LessonHelper lessonHelper = new LessonHelper();
        AppTypeHelper appTypeHelper = new AppTypeHelper();

        public Task GetById(Guid id)
        {
            TaskData data = new TaskData();

            return Translate(data.GetByID(id));
        }

        public List<Task> GetByLesson(Lesson lesson)
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

        public List<Task> GetAll()
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

        Task Translate(DataRow data)
        {
            Task newTask = new Task();

            newTask.ID = (Guid)(data["ID"]);
            newTask.Lesson = lessonHelper.GetById((Guid)data["LessonID"]);
            newTask.TaskString = data["Task"].ToString();
            if (data["App"] != DBNull.Value)
                newTask.App = (byte[])data["App"];
            newTask.AppType = appTypeHelper.GetById((Guid)(data["AppTypeID"]));
            newTask.TaskOrder = (int)data["TaskOrder"];

            return newTask;
        }

        public void Save(Task elem)
        {
            throw new NotImplementedException();
        }
    }
}
