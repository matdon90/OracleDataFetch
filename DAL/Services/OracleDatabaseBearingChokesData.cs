using DAL.Interfaces;
using DAL.Models;
using Oracle.ManagedDataAccess.Client;

namespace DAL.Services
{
    public class OracleDatabaseBearingChokesData : IBearingChokesData
    {
		private string connectionString = "DATA SOURCE=192.168.0.107:1521/OracleDB;USER ID=SCOTT;PASSWORD=Start123";
        public BearingChokes GetInstalledBearingChokes()
        {
            object[] bearingChokesRecord = new object[16];

            string queryString = "SELECT * FROM BearingChokesTable";

            using(OracleConnection connection = new OracleConnection(connectionString))
            {
                OracleCommand command = new OracleCommand(queryString, connection);
                connection.Open();
                using(OracleDataReader reader = command.ExecuteReader())
                {
                    reader.Read();
                    reader.GetValues(bearingChokesRecord);
                }
            }

            BearingChokes currentBearingChokes = new BearingChokes()
            {
                Std1_UpWR_Os_Choke_Nb = (short)bearingChokesRecord[0],
                Std1_UpWR_Ds_Choke_Nb = (short)bearingChokesRecord[1],
                Std1_BtmWR_Os_Choke_Nb = (short)bearingChokesRecord[2],
                Std1_BtmWR_Ds_Choke_Nb = (short)bearingChokesRecord[3],
                Std2_UpWR_Os_Choke_Nb = (short)bearingChokesRecord[4],
                Std2_UpWR_Ds_Choke_Nb = (short)bearingChokesRecord[5],
                Std2_BtmWR_Os_Choke_Nb = (short)bearingChokesRecord[6],
                Std2_BtmWR_Ds_Choke_Nb = (short)bearingChokesRecord[7],
                Std3_UpWR_Os_Choke_Nb = (short)bearingChokesRecord[8],
                Std3_UpWR_Ds_Choke_Nb = (short)bearingChokesRecord[9],
                Std3_BtmWR_Os_Choke_Nb = (short)bearingChokesRecord[10],
                Std3_BtmWR_Ds_Choke_Nb = (short)bearingChokesRecord[11],
                Std4_UpWR_Os_Choke_Nb = (short)bearingChokesRecord[12],
                Std4_UpWR_Ds_Choke_Nb = (short)bearingChokesRecord[13],
                Std4_BtmWR_Os_Choke_Nb = (short)bearingChokesRecord[14],
                Std4_BtmWR_Ds_Choke_Nb = (short)bearingChokesRecord[15]
            };

            return currentBearingChokes;
        }
    }
}
