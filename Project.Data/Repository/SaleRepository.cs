using Project.Data.Connection;
using Project.Data.Interface;
using Project.Entity;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using Project.Data.Generic;

namespace Project.Data.Repository
{
    public class SaleRepository : ISaleRepository
    {
        private string ConnectionString;

        public SaleRepository()
        {
            ConnectionString = MasterConnection.ConnectionString;
        }

        public int Create(Sale entity)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();

                var parameters = new
                {
                    UserId = entity.User.Id,
                    CustomerId = entity.Customer.Id,
                    Address = entity.Address,
                    NeighborhoodId = entity.Neighborhood.Id,
                    TransportationCompanyId = entity.TransportationCompany.Id,
                    PaymentType = entity.PaymentType,
                    TotalAmount = entity.TotalAmount,
                    CreatedAt = entity.CreatedAt,
                    SaleId = 0,
                };

                // Utilizar DynamicParameters para manejar parámetros de salida
                var dynamicParameters = new DynamicParameters(parameters);
                dynamicParameters.Add("@SaleId", dbType: DbType.Int32, direction: ParameterDirection.Output);

                dbConnection.Execute("CreateSale", dynamicParameters, commandType: CommandType.StoredProcedure);

                // Obtener el valor del parámetro de salida SaleId
                int saleId = dynamicParameters.Get<int>("@SaleId");

                return saleId;
            }
        }

        public bool Delete(int id)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();

                var parameters = new { SaleId = id };
                dbConnection.Execute("DeleteSale", parameters, commandType: CommandType.StoredProcedure);
            }

            return true;
        }

        public Sale Get(int id)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();

                var parameters = new { SaleId = id };
                return dbConnection.QueryFirstOrDefault<Sale>("GetSale", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<Sale> GetAll()
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();

                return dbConnection.Query<Sale>("GetAllSales", commandType: CommandType.StoredProcedure);
            }
        }

        public bool Update(Sale entity)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();

                var parameters = new
                {
                    SaleId = entity.Id,
                    UserId = entity.User.Id,
                    CustomerId = entity.Customer.Id,
                    Address = entity.Address,
                    NeighborhoodId = entity.Neighborhood.Id,
                    PaymentType = entity.PaymentType,
                    TotalAmount = entity.TotalAmount,
                    CreatedAt = entity.CreatedAt
                };

                dbConnection.Execute("UpdateSale", parameters, commandType: CommandType.StoredProcedure);
            }

            return true;
        }

        bool IGenericRepository<Sale>.Create(Sale entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
