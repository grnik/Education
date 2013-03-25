using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Providers
{
    interface IObjectHelper
    {
        /// <summary>
        /// Возвращает один объект по его ключу
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Object GetById(Guid id);

        /// <summary>
        /// Возвращает все объекты
        /// </summary>
        /// <returns></returns>
        List<Object> GetAll();
    }
}
