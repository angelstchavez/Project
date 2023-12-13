using Project.Data.Connection;
using Project.Data.Interface;
using Project.Entity;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using Project.Common.Security;

namespace Project.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private string ConnectionString;

        public UserRepository()
        {
            ConnectionString = MasterConnection.ConnectionString;
        }

        public bool Create(User user)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();

                string encryptedPassword = Encryptor.Encrypt(user.Password);

                var parameters = new
                {
                    Username = user.Username,
                    Password = encryptedPassword,
                    IsActive = user.IsActive,
                    RoleId = user.Role.Id
                };

                var userId = dbConnection.QuerySingleOrDefault<int>("CreateUser", parameters, commandType: CommandType.StoredProcedure);

                return userId > 0;
            }
        }

        public bool Delete(int id)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();

                var parameters = new { UserId = id };

                var affectedRows = dbConnection.Execute("DeleteUser", parameters, commandType: CommandType.StoredProcedure);

                return affectedRows > 0;
            }
        }

        public User Get(int id)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();

                var parameters = new { UserId = id };

                return dbConnection.QueryFirstOrDefault<User>("GetUser", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<User> GetAll()
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.Query<User>("GetAllUsers", commandType: CommandType.StoredProcedure);
            }
        }

        public bool Update(User user)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();

                var parameters = new
                {
                    UserId = user.Id,
                    Username = user.Username,
                    Password = user.Password,
                    IsActive = user.IsActive,
                    RoleId = user.Role.Id
                };

                var affectedRows = dbConnection.Execute("UpdateUser", parameters, commandType: CommandType.StoredProcedure);

                return affectedRows > 0;
            }
        }
    }
}
