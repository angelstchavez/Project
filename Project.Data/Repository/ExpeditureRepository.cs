using Project.Data.Connection;
using Project.Data.Interface;
using Project.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace Project.Data.Repository
{
    public class ExpeditureRepository : IExpeditureRepository
    {
        private string ConnectionString;

        public ExpeditureRepository()
        {
            ConnectionString = MasterConnection.ConnectionString;
        }

        public bool Create(Expenditure expediture)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();

                var parameters = new
                {
                    Date = expediture.Date,
                    Category = expediture.Category,
                    Description = expediture.Description,
                    Value = expediture.Value,
                    CreatedAt = expediture.CreatedAt
                };

                try
                {
                    var expenditureId = dbConnection.QuerySingleOrDefault<int>("CreateExpenditure", parameters, commandType: CommandType.StoredProcedure);
                    return expenditureId > 0;
                }
                catch (SqlException ex)
                {
                    // Handle duplicate entry error or rethrow the exception
                    if (ex.Number == 2601)  // SQL Server error for unique constraint violation
                    {
                        throw new Exception("Ya existe un gasto con esta fecha y categoría.");
                    }
                    throw;
                }
            }
        }

        public bool Delete(int id)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();

                var parameters = new { ExpenditureId = id };

                var affectedRows = dbConnection.Execute("DeleteExpenditure", parameters, commandType: CommandType.StoredProcedure);

                return affectedRows > 0;
            }
        }

        public Expenditure Get(int id)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();

                var parameters = new { ExpenditureId = id };

                return dbConnection.QueryFirstOrDefault<Expenditure>("GetExpenditure", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<Expenditure> GetAll()
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.Query<Expenditure>("GetAllExpenditures", commandType: CommandType.StoredProcedure);
            }
        }

        public bool Update(Expenditure expediture)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();

                var parameters = new
                {
                    ExpenditureId = expediture.Id,
                    Date = expediture.Date,
                    Category = expediture.Category,
                    Description = expediture.Description,
                    Value = expediture.Value,
                    CreatedAt = expediture.CreatedAt
                };

                try
                {
                    var affectedRows = dbConnection.Execute("UpdateExpenditure", parameters, commandType: CommandType.StoredProcedure);
                    return affectedRows > 0;
                }
                catch (SqlException ex)
                {
                    // Handle not found error or rethrow the exception
                    if (ex.Number == 50000 && ex.Class == 16 && ex.State == 1)  // Custom error from RAISEERROR
                    {
                        throw new Exception("Gasto no encontrado.");
                    }
                    throw;
                }
            }
        }

        public IEnumerable<Expenditure> GetBySpecificDate(DateTime date)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();

                var parameters = new { SpecificDate = date };

                return dbConnection.Query<Expenditure>("GetExpendituresBySpecificDate", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<ExpenditureDay> GetTotalExpensesPerDay()
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.Query<ExpenditureDay>("GetTotalExpensesPerDay", commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<Expenditure> GetAllExpensesByDate(DateTime date)
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                var parameters = new { SpecificDate = date };
                return dbConnection.Query<Expenditure>("GetAllExpensesByDate", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<SpendingByCategory> GetTotalExpenditureByCategory()
        {
            using (IDbConnection dbConnection = new SqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.Query<SpendingByCategory>("GetTotalExpenditureByCategory", commandType: CommandType.StoredProcedure);
            }
        }
    }
}
    