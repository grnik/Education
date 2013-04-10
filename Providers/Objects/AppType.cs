using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Providers
{
    using DataAccess;

    public class AppType : ModelObject
    {
        static AppTypeHelper appTypeHelper = new AppTypeHelper();

        static public AppType AppTypeDataText
        {
            get
            {
                return appTypeHelper.GetById(AppTypeData.AppTypeDataText.ID);
            }
        }
        static public AppType AppTypeDataApplication
        {
            get
            {
                return appTypeHelper.GetById(AppTypeData.AppTypeDataApplication.ID);
            }
        }

        /// <summary>
        /// Название типа
        /// </summary>
        public string Name { get; set; }
    }
}
