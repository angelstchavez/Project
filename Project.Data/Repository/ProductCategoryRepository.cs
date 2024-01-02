using Project.Data.Connection;
using Project.Data.Interface;
using Project.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace Project.Data.Repository
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private string ConnectionString;

        public ProductCategoryRepository()
        {
            ConnectionString = MasterConnection.ConnectionString;
        }

        public bool Create(ProductCategory category)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                string query = "CreateProductCategory";
                var parameters = new
                {
                    Name = category.Name,
                    IsActive = category.IsActive
                };

                try
                {
                    dbConnection.Execute(query, parameters, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool Delete(int id)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                string query = "DeleteProductCategory";
                var parameters = new { Id = id };

                try
                {
                    dbConnection.Execute(query, parameters, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public ProductCategory Get(int id)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                string query = "GetProductCategory";
                var parameters = new { Id = id };

                try
                {
                    return dbConnection.QuerySingleOrDefault<ProductCategory>(query, parameters, commandType: CommandType.StoredProcedure);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public IEnumerable<ProductCategory> GetAll()
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                string query = "GetAllActiveProductCategory";

                try
                {
                    return dbConnection.Query<ProductCategory>(query, commandType: CommandType.StoredProcedure);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool Update(ProductCategory category)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                string query = "UpdateProductCategory";
                var parameters = new
                {
                    Id = category.Id,
                    Name = category.Name,
                    IsActive = category.IsActive
                };

                try
                {
                    dbConnection.Execute(query, parameters, commandType: CommandType.StoredProcedure);
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
