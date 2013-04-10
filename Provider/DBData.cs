using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    using System.Data.SqlTypes;
    using System.IO;

    public abstract class DBData : ITable
    {
        private const string ConnectionString = @"Data Source=C0009;Initial Catalog=Education;Integrated Security=True";
        private static SqlConnection _connection = null;

        internal SqlDataAdapter da;
        internal DataSet ds;

        public abstract string TableName { get; }

        public static SqlConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new SqlConnection(ConnectionString);
                }

                return _connection;
            }
        }

        public DBData()
        {
            this.DataSetTable();
        }

        /// <summary>
        /// Вернуть все записи таблицы
        /// </summary>
        public DataTable GetAll()
        {
            try
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = Connection;
                    comm.CommandText = "select * from " + TableName;
                    da.SelectCommand = comm;
                    da.Fill(ds, TableName);

                    return ds.Tables[TableName];
                }
            }
            catch (Exception)
            {
                return new DataTable(TableName);
            }
        }

        public DataRow GetByID(Guid id)
        {
            try
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = Connection;
                    comm.CommandText = "select * from " + TableName + " where ID = @ID";
                    comm.Parameters.AddWithValue("ID", id);
                    da.SelectCommand = comm;
                    da.Fill(ds, TableName);

                    if (ds.Tables[TableName].Rows.Count < 1) return null;

                    return ds.Tables[TableName].Rows[0];
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        #region Сохранение и чтение данных включая файлы
        //По мотивам статьи http://support.microsoft.com/kb/309158/ru

        private void DataSetTable()
        {
            da = new SqlDataAdapter("Select * From " + TableName, Connection);
            SqlCommandBuilder MyCB = new SqlCommandBuilder(da);
            ds = new DataSet(TableName);

            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, TableName);
        }

        internal DataRow NewRow()
        {
            this.DataSetTable();

            DataRow myRow = ds.Tables[TableName].NewRow();

            return myRow;
        }

        internal bool AddRow(DataRow newRow)
        {
            ds.Tables[TableName].Rows.Add(newRow);
            da.Update(ds, TableName);

            return true;
        }

        public bool Save()
        {
            da.Update(ds, TableName);

            return true;
        }

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

        public char[] DataCellToChar()
        {
            return null;
        }

        #endregion
    }
}
