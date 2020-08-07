using DAL.Models;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface IBearingChokesData
    {
        IEnumerable<BearingChokes> GetInstalledBearingChokes();
    }
}
