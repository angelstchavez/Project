using Project.Data.Generic;
using Project.Entity;
using System;
using System.Collections.Generic;

namespace Project.Data.Interface
{
    public interface IExpeditureRepository : IGenericRepository<Expenditure>
    {
        IEnumerable<Expenditure> GetBySpecificDate(DateTime date);
        IEnumerable<ExpenditureDay> GetTotalExpensesPerDay();
        IEnumerable<Expenditure> GetAllExpensesByDate(DateTime date);
        IEnumerable<SpendingByCategory> GetTotalExpenditureByCategory();
    }
}
