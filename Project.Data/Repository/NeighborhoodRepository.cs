using Project.Data.Connection;
using Project.Entity;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace Project.Data.Repository
{
    public class NeighborhoodRepository
    {
        private readonly string ConnectionString;

        public NeighborhoodRepository()
        {
            ConnectionString = MasterConnection.ConnectionString;
        }

        public IEnumerable<int> GetDistinctCommunes()
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.Query<int>("GetDistinctCommunes", commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<Neighborhood> GetByCommune(int communeNumber)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                var parameters = new { CommuneNumber = communeNumber };
                return dbConnection.Query<Neighborhood>("GetNeighborhoodsByCommune", parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
