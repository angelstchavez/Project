using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Project.Data.Connection;
using Project.Data.Interface;
using Project.Entity;

namespace Project.Data.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly string ConnectionString;

        public CustomerRepository()
        {
            ConnectionString = MasterConnection.ConnectionString;
        }

        public bool Create(Customer entity)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                using (var transaction = dbConnection.BeginTransaction())
                {
                    try
                    {
                        int affectedRows = dbConnection.Execute(
                            "CreateCustomer",
                            new
                            {
                                entity.Name,
                                entity.Phone,
                                entity.CreatedAt
                            },
                            commandType: CommandType.StoredProcedure,
                            transaction: transaction
                        );

                        if (affectedRows > 0)
                        {
                            transaction.Commit();
                            return true;
                        }
                        else
                        {
                            transaction.Rollback();
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public bool Delete(int id)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                using (var transaction = dbConnection.BeginTransaction())
                {
                    try
                    {
                        int affectedRows = dbConnection.Execute(
                            "DeleteCustomer",
                            new { CustomerId = id },
                            commandType: CommandType.StoredProcedure,
                            transaction: transaction
                        );

                        if (affectedRows > 0)
                        {
                            transaction.Commit();
                            return true;
                        }
                        else
                        {
                            transaction.Rollback();
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public Customer Get(int id)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.Query<Customer>(
                    "GetCustomer",
                    new { CustomerId = id },
                    commandType: CommandType.StoredProcedure
                ).FirstOrDefault();
            }
        }

        public IEnumerable<Customer> GetAll()
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.Query<Customer>(
                    "GetAllCustomers",
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        public Customer GetByPhoneNumber(string phoneNumber)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.QueryFirstOrDefault<Customer>(
                    "GetCustomerByPhoneNumber",
                    new { PhoneNumber = phoneNumber },
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        public int GetCustomerCountForToday()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var result = connection.QueryFirstOrDefault<int>("GetCustomerCountForToday", commandType: CommandType.StoredProcedure);

                return result;
            }
        }

        public IEnumerable<Customer> GetPagedCustomers(int pageSize, int pageNumber)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                var parameters = new
                {
                    PageSize = pageSize,
                    PageNumber = pageNumber
                };

                return dbConnection.Query<Customer>(
                    "GetPagedCustomers",
                    parameters,
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        public int GetTotalCustomerCount()
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.ExecuteScalar<int>(
                    "GetTotalCustomerCount",
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        public bool Update(Customer entity)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                using (var transaction = dbConnection.BeginTransaction())
                {
                    try
                    {
                        int affectedRows = dbConnection.Execute(
                            "UpdateCustomer",
                            new
                            {
                                entity.Id,
                                entity.Name,
                                entity.Phone,
                                entity.CreatedAt
                            },
                            commandType: CommandType.StoredProcedure,
                            transaction: transaction
                        );

                        if (affectedRows > 0)
                        {
                            transaction.Commit();
                            return true;
                        }
                        else
                        {
                            transaction.Rollback();
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }
    }
}
