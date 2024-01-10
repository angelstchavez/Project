using Project.Data.Generic;
using Project.Entity;
using System.Collections.Generic;

namespace Project.Data.Interface
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        IEnumerable<Customer> GetPagedCustomers(int pageSize, int pageNumber);
        int GetTotalCustomerCount();
    }
}
