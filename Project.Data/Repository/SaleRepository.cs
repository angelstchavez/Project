using Project.Data.Connection;
using Project.Data.Interface;
using Project.Entity;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using Project.Data.Generic;
using System;

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

        public decimal GetCashSalesForToday()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var result = connection.QueryFirstOrDefault<decimal>("GetCashSalesForToday", commandType: CommandType.StoredProcedure);

                return result;
            }
        }

        public decimal GetDaviplataSalesForToday()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var result = connection.QueryFirstOrDefault<decimal>("GetDaviplataSalesForToday", commandType: CommandType.StoredProcedure);

                return result;
            }
        }

        public decimal GetNequiSalesForToday()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var result = connection.QueryFirstOrDefault<decimal>("GetNequiSalesForToday", commandType: CommandType.StoredProcedure);

                return result;
            }
        }

        public IEnumerable<DetailedProduct> GetProductSalesForToday()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var products = connection.Query<DetailedProduct>("GetProductSalesForToday", commandType: CommandType.StoredProcedure);

                return products;
            }
        }

        public int GetSaleCount()
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.ExecuteScalar<int>("GetSaleCount", commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<DetailedSale> GetSalesForToday()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var sales = connection.Query<DetailedSale>("GetSalesForToday", commandType: CommandType.StoredProcedure);

                return sales;
            }
        }

        public decimal GetTotalSalesAmount()
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.ExecuteScalar<decimal>("GetTotalSalesAmount", commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<SalePerDay> GetTotalSalesPerDay()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var sales = connection.Query<SalePerDay>("GetTotalSalesPerDay", commandType: CommandType.StoredProcedure);

                return sales;
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
