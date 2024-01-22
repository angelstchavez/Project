using Project.Data.Generic;
using Project.Entity;
using System.Collections.Generic;

namespace Project.Data.Interface
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        IEnumerable<Product> GetByCategoryId(int categoryId);
        IEnumerable<ProductSale> GetProductSales();
        IEnumerable<ProductSale> GetProductSalesByCategory(string category);
    }
}
