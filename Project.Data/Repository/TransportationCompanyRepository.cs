using Project.Data.Connection;
using Project.Data.Interface;
using Project.Entity;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace Project.Data.Repository
{
    public class TransportationCompanyRepository : ITransportationCompanyRepository
    {
        private readonly string ConnectionString;

        public TransportationCompanyRepository()
        {
            ConnectionString = MasterConnection.ConnectionString;
        }

        public bool Create(TransportationCompany transportationCompany)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                var parameters = new
                {
                    transportationCompany.Name,
                    transportationCompany.CreatedAt
                };

                var result = dbConnection.Execute("CreateTransportationCompany", parameters, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }

        public bool Delete(int id)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                var parameters = new { Id = id };

                var result = dbConnection.Execute("DeleteTransportationCompany", parameters, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }

        public TransportationCompany Get(int id)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                var parameters = new { Id = id };

                return dbConnection.QueryFirstOrDefault<TransportationCompany>("GetTransportationCompany", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<TransportationCompany> GetAll()
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                return dbConnection.Query<TransportationCompany>("GetAllTransportationCompanies", commandType: CommandType.StoredProcedure);
            }
        }

        public bool Update(TransportationCompany transportationCompany)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                var parameters = new
                {
                    transportationCompany.Id,
                    transportationCompany.Name,
                    transportationCompany.CreatedAt
                };

                var result = dbConnection.Execute("UpdateTransportationCompany", parameters, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }
    }
}
