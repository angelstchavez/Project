using Project.Data.Generic;
using Project.Entity;
using System;
using System.Collections.Generic;

namespace Project.Data.Interface
{
    public interface ISaleRepository : IGenericRepository<Sale>
    {
        IEnumerable<DetailedSale> GetSalesForToday();

        IEnumerable<DetailedSale> GetSalesForDate(DateTime targetDate);

        IEnumerable<DetailedProduct> GetProductSalesForToday();

        IEnumerable<DetailedProduct> GetProductSalesForDate(DateTime targetDate);
        
        decimal GetCashSalesForToday();

        decimal GetDaviplataSalesForToday();

        decimal GetNequiSalesForToday();
        
        decimal GetCashSalesForDate(DateTime targetDate);

        decimal GetDaviplataSalesForDate(DateTime targetDate);

        decimal GetNequiSalesForDate(DateTime targetDate);

        IEnumerable<SalePerDay> GetTotalSalesPerDay();
        int GetSaleCount();
        decimal GetTotalSalesAmount();
    }
}
