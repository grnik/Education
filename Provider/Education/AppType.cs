using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Provider.Education
{
    public class AppType
    {
        public static AppType AppTypeText = new AppType { ID = new Guid("55669507-5043-4b1b-9eda-358a46a95a35"), Name = "Text" };
        public static AppType AppTypeApplication = new AppType { ID = new Guid("{50453584-EACB-4662-8205-00D6E1009DBE}"), Name = "Application" };

        public Guid ID;

        public string Name;
    }
}
