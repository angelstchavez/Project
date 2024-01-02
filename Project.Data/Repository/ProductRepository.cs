using Dapper;
using Project.Data.Connection;
using Project.Data.Interface;
using Project.Entity;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Project.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly string ConnectionString;

        public ProductRepository()
        {
            ConnectionString = MasterConnection.ConnectionString;
        }

        public bool Create(Product entity)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();

                var parameters = new
                {
                    Name = entity.Name,
                    Price = entity.Price,
                    CategoryId = entity.Category.Id,
                    IsActive = entity.IsActive
                };

                int rowsAffected = dbConnection.Execute("CreateProduct", parameters, commandType: CommandType.StoredProcedure);

                return rowsAffected > 0;
            }
        }

        public bool Update(Product entity)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();

                var parameters = new
                {
                    Id = entity.Id,
                    Name = entity.Name,
                    Price = entity.Price,
                    CategoryId = entity.Category.Id,
                    IsActive = entity.IsActive
                };

                int rowsAffected = dbConnection.Execute("UpdateProduct", parameters, commandType: CommandType.StoredProcedure);

                return rowsAffected > 0;
            }
        }

        public IEnumerable<Product> GetAll()
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();

                return dbConnection.Query<Product>("GetAllActiveProducts", commandType: CommandType.StoredProcedure);
            }
        }

        public Product Get(int id)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();

                var parameters = new { Id = id };
                return dbConnection.QueryFirstOrDefault<Product>("GetProduct", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public bool Delete(int id)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();

                var parameters = new { Id = id };
                int rowsAffected = dbConnection.Execute("DeleteProduct", parameters, commandType: CommandType.StoredProcedure);

                return rowsAffected > 0;
            }
        }

        public IEnumerable<Product> GetByCategoryId(int categoryId)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();

                var parameters = new { CategoryId = categoryId };
                return dbConnection.Query<Product>("GetActiveProductsByCategoryId", parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
