using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Providers
{
    using System.IO;

    /// <summary>
    /// Описание урока
    /// </summary>
    public class Lesson : Object
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public byte[] App { get; set; }

        public AppType AppType { get; set; }
    }
}
