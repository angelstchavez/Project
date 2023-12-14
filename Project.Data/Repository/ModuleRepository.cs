using Project.Data.Connection;
using Project.Data.Interface;
using Project.Entity;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace Project.Data.Repository
{
    public class ModuleRepository : IModuleRepository
    {
        private string ConnectionString;

        public ModuleRepository()
        {
            ConnectionString = MasterConnection.ConnectionString;
        }

        public bool Create(Module module)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                var parameters = new
                {
                    ModuleName = module.Name,
                    RoleId = module.Role.Id
                };
                var result = dbConnection.Execute("CreateModule", parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public bool Delete(int id)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                var parameters = new { ModuleId = id };
                var result = dbConnection.Execute("DeleteModule", parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public Module Get(int id)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                var parameters = new { ModuleId = id };
                return dbConnection.QueryFirstOrDefault<Module>("GetModule", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<Module> GetAll()
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.Query<Module>("SELECT * FROM Modules");
            }
        }

        public IEnumerable<Module> GetModulesByUserId(int id)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                var parameters = new { UserId = id };
                return dbConnection.Query<Module>("GetModulesByUserId", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public bool Update(Module module)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                var parameters = new
                {
                    ModuleId = module.Id,
                    ModuleName = module.Name,
                    RoleId = module.Role.Id
                };
                var result = dbConnection.Execute("UpdateModule", parameters, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }
    }
}
