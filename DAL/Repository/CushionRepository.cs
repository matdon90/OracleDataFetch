using DAL.Models;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;

namespace DAL.Repository
{
    public class CushionRepository : OdpRepository<Cushion>
    {
        private readonly string _tableName;
        public CushionRepository(string connectionString, string tableName) : base(connectionString)
        {
            _tableName = tableName;
        }
        protected override Cushion PopulateRecord(OracleDataReader reader)
        {
            return new Cushion
            {
                Stand = (short)reader.GetInt32(0),
                Place = reader.GetString(1),
                Typ = reader.GetString(2),
                CushOs = (short)reader.GetInt32(3),
                CushDs = (short)reader.GetInt32(4),
            };
        }

        public IEnumerable<Cushion> GetAllInstalledCushions()
        {
            using (var command = new OracleCommand($"SELECT * FROM {_tableName} WHERE typ='AW' ORDER BY stand, place"))
            {
                return GetRecords(command);
            }
        }

        public Cushion GetInstalledCushionByPosition(int standNumber, string position)
        {
            using (var command = new OracleCommand($"SELECT * FROM {_tableName} WHERE typ='AW' AND stand= {standNumber} AND place='{position}'"))
            {
                return GetRecord(command);
            }
        }
    }
}
