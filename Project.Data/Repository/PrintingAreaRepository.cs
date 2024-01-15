using Dapper;
using Project.Data.Connection;
using Project.Data.Interface;
using Project.Entity;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Project.Data.Repository
{
    public class PrintingAreaRepository : IPrintingAreaRepository
    {
        private string ConnectionString;

        public PrintingAreaRepository()
        {
            ConnectionString = MasterConnection.ConnectionString;
        }

        public bool Create(PrintingArea printingArea)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                var affectedRows = dbConnection.Execute("CreatePrintingArea", printingArea, commandType: CommandType.StoredProcedure);
                return affectedRows > 0;
            }
        }

        public bool Delete(int id)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                var parameters = new { Id = id };
                var affectedRows = dbConnection.Execute("DeletePrintingArea", parameters, commandType: CommandType.StoredProcedure);
                return affectedRows > 0;
            }
        }

        public PrintingArea Get(int id)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                var parameters = new { Id = id };
                return dbConnection.QueryFirstOrDefault<PrintingArea>("GetPrintingArea", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<PrintingArea> GetAll()
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.Query<PrintingArea>("GetAllPrintingAreas", commandType: CommandType.StoredProcedure);
            }
        }

        public bool Update(PrintingArea printingArea)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                var affectedRows = dbConnection.Execute("UpdatePrintingArea", printingArea, commandType: CommandType.StoredProcedure);
                return affectedRows > 0;
            }
        }
    }
}
