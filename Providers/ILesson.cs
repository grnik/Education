using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Providers
{
    using System.IO;

    interface ILesson : ITable
    {
        #region Свойства

        Guid Id { get; set; }

        string Name { get; set; }

        string Description { get; set; }

        Stream App { get; set; }

        IAppType AppType { get; set; }

        #endregion

        #region Методы

        ITable GetById(Guid id);

        List<ITable> GetAll();

        #endregion
    }
}
