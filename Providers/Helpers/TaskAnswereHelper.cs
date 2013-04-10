using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccess;

namespace Providers
{

    public class TaskAnswereHelper : IModelHelper<TaskAnswere>
    {
        TaskHelper taskHelper = new TaskHelper();

        public TaskAnswere GetById(Guid id)
        {
            TaskAnswereData data = new TaskAnswereData();

            return Translate(data.GetByID(id));
        }

        public List<TaskAnswere> GetByTask(Task task)
        {
            TaskAnswereData data = new TaskAnswereData();

            List<TaskAnswere> list = new List<TaskAnswere>();

            DataTable table = data.GetByTask(task.ID);
            foreach (DataRow row in table.Rows)
            {
                list.Add(Translate(row));
            }
            return list;
        }

        public List<TaskAnswere> GetAll()
        {
            TaskAnswereData data = new TaskAnswereData();

            List<TaskAnswere> list = new List<TaskAnswere>();

            DataTable table = data.GetAll();
            foreach (DataRow row in table.Rows)
            {
                list.Add(Translate(row));
            }
            return list;
        }

        TaskAnswere Translate(DataRow data)
        {
            TaskAnswere newTaskAnsw = new TaskAnswere();

            newTaskAnsw.ID = (Guid)(data["ID"]);
            newTaskAnsw.Task = taskHelper.GetById((Guid)data["TaskID"]);
            newTaskAnsw.AnswereOrder = (int)data["AnswereOrder"];
            newTaskAnsw.Visible = (int)data["Visible"];

            return newTaskAnsw;
        }

        public void Save(TaskAnswere elem)
        {
            throw new NotImplementedException();
        }
    }
}
