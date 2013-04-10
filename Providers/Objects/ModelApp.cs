using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Providers
{
    /// <summary>
    /// Объект содержащий ссылку на загрузку приложения.
    /// </summary>
    abstract public class ModelApp : ModelObject
    {
        /// <summary>
        /// Загруженное приложение
        /// </summary>
        public byte[] App { get; set; }

        /// <summary>
        /// Тип загруженного приложения
        /// </summary>
        public AppType AppType { get; set; }

        /// <summary>
        /// Добавляем приложение (файл)
        /// </summary>
        /// <param name="application"></param>
        public void AddApp(byte[] application)
        {
            this.AppType = AppType.AppTypeDataApplication;
            this.App = application;
        }

        /// <summary>
        /// Добавляем приложение (текст)
        /// </summary>
        /// <param name="application"></param>
        public void AddApp(string application)
        {
            this.AppType = AppType.AppTypeDataText;
            this.App = StringToByte(application);
        }

        public static byte[] StringToByte(string stringData)
        {
            char[] res = stringData.ToCharArray();
            byte[] result = new byte[res.Length];
            for (int i = 0; i < res.Length; i++)
            {
                result[i] = (byte)res[i];
            }

            return result;
        }
    }
}
