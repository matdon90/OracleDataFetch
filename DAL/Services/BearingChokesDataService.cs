using DAL.Interfaces;
using DAL.Models;
using DAL.Repository;
using System.Collections.Generic;

namespace DAL.Services
{
    public class BearingChokesDataService : IBearingChokesData
    {
        private string connectionString = "DATA SOURCE=192.168.0.107:1521/OracleDB;USER ID=SCOTT;PASSWORD=Start123";
        private string tableName = "BearingChokesTable";
        private readonly BearingChokesRepository _repository;
        public BearingChokesDataService()
        {
            _repository = new BearingChokesRepository(connectionString, tableName);
        }

        public IEnumerable<BearingChokes> GetInstalledBearingChokes()
        {
            return _repository.GetInstalledBearingChokes();
        }
    }
}
