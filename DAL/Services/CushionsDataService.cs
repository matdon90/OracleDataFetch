using DAL.Interfaces;
using DAL.Models;
using DAL.Repository;
using System.Collections.Generic;

namespace DAL.Services
{
    public class CushionsDataService : ICushionsData
    {
        private readonly string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["OracleDb"].ConnectionString;
        private readonly string tableName = System.Configuration.ConfigurationManager.AppSettings["CushionsTableName"].ToString();
        private readonly CushionRepository _repository;

        public CushionsDataService()
        {
            _repository = new CushionRepository(connectionString, tableName);
        }

        public IEnumerable<Cushion> GetAllInstalledCushions()
        {
            return _repository.GetAllInstalledCushions();
        }

        public Cushion GetInstalledCushionByPosition(int standNumber, string position)
        {
            return _repository.GetInstalledCushionByPosition(standNumber, position);
        }
    }
}
