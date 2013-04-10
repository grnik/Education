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
    public class Lesson : ModelApp
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Order { get; set; }

        public Course Course { get; set; }
    }
}
