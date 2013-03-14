using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Provider
{
    using System.Data;

    /// <summary>
    /// Описание реализации таблицы с данными.
    /// </summary>
    interface ITable
    {
        /// <summary>
        /// Имя реализуемой таблицы
        /// </summary>
        string TableName { get; }

        DataTable GetAll();
    }
}
