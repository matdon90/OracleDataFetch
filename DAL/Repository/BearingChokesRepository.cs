using DAL.Models;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;

namespace DAL.Repository
{
    public class BearingChokesRepository : OdpRepository<BearingChokes>
    {
        private readonly string _tableName;
        public BearingChokesRepository(string connectionString, string tableName) : base(connectionString) 
        {
            _tableName = tableName;
        }

        protected override BearingChokes PopulateRecord(OracleDataReader reader)
        {
            return new BearingChokes
            {
                Std1_UpWR_Os_Choke_Nb = (short)reader.GetInt32(0),
                Std1_UpWR_Ds_Choke_Nb = (short)reader.GetInt32(1),
                Std1_BtmWR_Os_Choke_Nb = (short)reader.GetInt32(2),
                Std1_BtmWR_Ds_Choke_Nb = (short)reader.GetInt32(3),
                Std2_UpWR_Os_Choke_Nb = (short)reader.GetInt32(4),
                Std2_UpWR_Ds_Choke_Nb = (short)reader.GetInt32(5),
                Std2_BtmWR_Os_Choke_Nb = (short)reader.GetInt32(6),
                Std2_BtmWR_Ds_Choke_Nb = (short)reader.GetInt32(7),
                Std3_UpWR_Os_Choke_Nb = (short)reader.GetInt32(8),
                Std3_UpWR_Ds_Choke_Nb = (short)reader.GetInt32(9),
                Std3_BtmWR_Os_Choke_Nb = (short)reader.GetInt32(10),
                Std3_BtmWR_Ds_Choke_Nb = (short)reader.GetInt32(11),
                Std4_UpWR_Os_Choke_Nb = (short)reader.GetInt32(12),
                Std4_UpWR_Ds_Choke_Nb = (short)reader.GetInt32(13),
                Std4_BtmWR_Os_Choke_Nb = (short)reader.GetInt32(14),
                Std4_BtmWR_Ds_Choke_Nb = (short)reader.GetInt32(15)
            };
        }

        public IEnumerable<BearingChokes> GetInstalledBearingChokes()
        {
            using (var command = new OracleCommand($"SELECT * FROM {_tableName}"))
            {
                return GetRecords(command);
            }
        }

    }
}
