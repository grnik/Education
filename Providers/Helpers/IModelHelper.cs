using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Providers
{
    interface IModelHelper<T> where T : ModelObject
    {
        /// <summary>
        /// Возвращает один объект по его ключу
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(Guid id);

        /// <summary>
        /// Возвращает все объекты
        /// </summary>
        /// <returns></returns>
        List<T> GetAll();

        void Save(T elem);
    }
}
