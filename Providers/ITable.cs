using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Providers
{
    interface ITable
    {
        #region Свойства

        Guid Id { get; set; }

        #endregion

        #region Методы

        ITable GetById(Guid id);

        List<ITable> GetAll();

        #endregion
    }
}
