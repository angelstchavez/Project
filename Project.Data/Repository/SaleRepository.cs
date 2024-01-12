using Project.Data.Connection;
using Project.Data.Interface;
using Project.Entity;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace Project.Data.Repository
{
    public class SaleRepository : ISaleRepository
    {
        private string ConnectionString;

        public SaleRepository()
        {
            ConnectionString = MasterConnection.ConnectionString;
        }

        public bool Create(Sale entity)
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
                    PaymentType = entity.PaymentType,
                    TotalAmount = entity.TotalAmount,
                    CreatedAt = entity.CreatedAt
                };

                dbConnection.Execute("CreateSale", parameters, commandType: CommandType.StoredProcedure);
            }

            return true;
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
    }
}
