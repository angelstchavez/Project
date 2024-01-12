using Dapper;
using Project.Data.Connection;
using Project.Data.Interface;
using Project.Entity;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Project.Data.Repository
{
    public class SaleDetailRepository : ISaleDetailRepository
    {
        private string ConnectionString;

        public SaleDetailRepository()
        {
            ConnectionString = MasterConnection.ConnectionString;
        }

        public bool Create(SaleDetail saleDetail)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.Execute("CreateSaleDetail", saleDetail, commandType: System.Data.CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public bool Delete(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.Execute("DeleteSaleDetail", new { Id = id }, commandType: System.Data.CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public SaleDetail Get(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                return connection.QueryFirstOrDefault<SaleDetail>("GetSaleDetail", new { Id = id }, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public IEnumerable<SaleDetail> GetAll()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                return connection.Query<SaleDetail>("GetAllSaleDetails", commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public bool Update(SaleDetail saleDetail)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.Execute("UpdateSaleDetail", saleDetail, commandType: System.Data.CommandType.StoredProcedure);
                return result > 0;
            }
        }
    }
}
