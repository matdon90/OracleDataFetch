using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;

namespace DAL.Repository
{
    public abstract class OdpRepository<T> where T : class
    {
        private static OracleConnection _connection;
        public OdpRepository(string connectionString)
        {
            _connection = new OracleConnection(connectionString);
        }

        protected abstract T PopulateRecord(OracleDataReader reader);
 

        protected IEnumerable<T> GetRecords(OracleCommand command)
        {
            var list = new List<T>();
            command.Connection = _connection;
            _connection.Open();
            try
            {
                var reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                        list.Add(PopulateRecord(reader));
                }
                finally
                {
                    reader.Close();
                }
            }
            finally
            {
                _connection.Close();
            }
            return list;
        }

        protected T GetRecord(OracleCommand command)
        {
            T record = null;
            command.Connection = _connection;
            _connection.Open();
            try
            {
                var reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        record = PopulateRecord(reader);
                        break;
                    }
                }
                finally
                {
                    reader.Close();
                }
            }
            finally
            {
                _connection.Close();
            }
            return record;
        }

    }
}
