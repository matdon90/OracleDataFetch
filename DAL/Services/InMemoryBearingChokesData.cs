using DAL.Interfaces;
using DAL.Models;

namespace DAL.Services
{
    public class InMemoryBearingChokesData : IBearingChokesData
    {
        BearingChokes installedBearingChokes;

        public InMemoryBearingChokesData()
        {
            installedBearingChokes = new BearingChokes()
            {
                Std1_UpWR_Os_Choke_Nb = 101,
                Std1_UpWR_Ds_Choke_Nb = 102,
                Std1_BtmWR_Os_Choke_Nb = 103,
                Std1_BtmWR_Ds_Choke_Nb = 104,
                Std2_UpWR_Os_Choke_Nb = 201,
                Std2_UpWR_Ds_Choke_Nb = 202,
                Std2_BtmWR_Os_Choke_Nb = 203,
                Std2_BtmWR_Ds_Choke_Nb = 204,
                Std3_UpWR_Os_Choke_Nb = 301,
                Std3_UpWR_Ds_Choke_Nb = 302,
                Std3_BtmWR_Os_Choke_Nb = 303,
                Std3_BtmWR_Ds_Choke_Nb = 304,
                Std4_UpWR_Os_Choke_Nb = 401,
                Std4_UpWR_Ds_Choke_Nb = 402,
                Std4_BtmWR_Os_Choke_Nb = 403,
                Std4_BtmWR_Ds_Choke_Nb = 404
            };
        }

        public BearingChokes GetInstalledBearingChokes()
        {
            return installedBearingChokes;
        }
    }
}
