using Project.Data.Generic;
using Project.Entity;
using System.Collections.Generic;

namespace Project.Data.Interface
{
    public interface ISaleRepository : IGenericRepository<Sale>
    {
        IEnumerable<DetailedSale> GetSalesForToday();
    }
}
