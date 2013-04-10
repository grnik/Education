using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccess;

namespace Providers
{
    using DataModel;

    public class AppTypeHelper : IModelHelper<AppType>
    {
        public AppType GetById(Guid id)
        {
            using (DataModel.EducationEntities context = new EducationEntities())
            {
                DataModel.AppType appType = context.AppTypes.FirstOrDefault(a => a.ID == id);

                return Translate(appType);
            }
        }

        public List<AppType> GetAll()
        {
            using (DataModel.EducationEntities context = new EducationEntities())
            {
                List<AppType> list = new List<AppType>();

                foreach (var elem in context.AppTypes)
                {
                    list.Add(Translate(elem));
                }
                return list;
            }
        }

        static AppType Translate(DataRow data)
        {
            AppType newAppType = new AppType();

            newAppType.ID = (Guid)(data["ID"]);
            newAppType.Name = data["Name"].ToString();

            return newAppType;
        }

        static AppType Translate(DataModel.AppType appType)
        {
            AppType newAppType = new AppType();

            newAppType.ID = appType.ID;
            newAppType.Name = appType.Name;

            return newAppType;
        }

        public void Save(AppType elem)
        {
            using (DataModel.EducationEntities context = new EducationEntities())
            {
                DataModel.AppType appType = context.AppTypes.FirstOrDefault(a => a.ID == elem.ID);
                if(appType == null)
                {
                    appType = new DataModel.AppType();
                    appType.ID = Guid.NewGuid();
                }
                appType.Name = elem.Name;

                context.SaveChanges();
            }
        }
    }
}
