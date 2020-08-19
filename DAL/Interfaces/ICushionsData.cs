using DAL.Models;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface ICushionsData
    {
        IEnumerable<Cushion> GetAllInstalledCushions();
        Cushion GetInstalledCushionByPosition(int standNumber, string position);
    }
}
