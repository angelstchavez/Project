using Project.Data.Generic;
using Project.Entity;
using System.Collections.Generic;

namespace Project.Data.Interface
{
    public interface ISaleRepository : IGenericRepository<Sale>
    {
        IEnumerable<DetailedSale> GetSalesForToday();

        IEnumerable<DetailedProduct> GetProductSalesForToday();

        decimal GetCashSalesForToday();

        decimal GetDaviplataSalesForToday();

        decimal GetNequiSalesForToday();
    }
}
