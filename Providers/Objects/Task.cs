using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Providers
{
    public class Task : ModelObject
    {
        public Lesson Lesson;
        public string TaskString;
        public byte[] App;
        public int? TaskOrder;
        public AppType AppType;
    }
}
