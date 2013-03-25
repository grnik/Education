using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
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

        /// <summary>
        /// Возвращаем сроку по ее ключу
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        DataRow GetByID(Guid id);

        /// <summary>
        /// Возвращаем все строки
        /// </summary>
        /// <returns></returns>
        DataTable GetAll();
    }
}
