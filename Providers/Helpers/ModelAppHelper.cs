using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Providers
{

    public abstract class ModelAppHelper<T> : IModelHelper<T> where T : ModelApp
    {
        /// <summary>
        /// Возвращает один объект по его ключу
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public abstract T GetById(Guid id);

        /// <summary>
        /// Возвращает все объекты
        /// </summary>
        /// <returns></returns>
        public abstract List<T> GetAll();

        public abstract void Save(T elem);


        public static byte[] FileToByte(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read);

            byte[] MyData = new byte[fs.Length];
            fs.Read(MyData, 0, System.Convert.ToInt32(fs.Length));

            fs.Close();

            return MyData;
        }

        public static string ByteToString(byte[] binaryData)
        {
            Encoding encoding = Encoding.Default;

            return encoding.GetString(binaryData);
        }
    }
}
