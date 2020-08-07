using DAL.Interfaces;
using DAL.Models;
using DAL.Repository;
using System.Collections.Generic;

namespace DAL.Services
{
    public class BearingChokesDataService : IBearingChokesData
    {
        private readonly string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OracleDb"].ConnectionString;
        private readonly string tableName = System.Configuration.ConfigurationManager.AppSettings["BearingChokesTableName"].ToString();

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
