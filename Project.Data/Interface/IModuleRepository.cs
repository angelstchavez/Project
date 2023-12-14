using Project.Data.Generic;
using Project.Entity;
using System.Collections.Generic;

namespace Project.Data.Interface
{
    public interface IModuleRepository : IGenericRepository<Module>
    {
        IEnumerable<Module> GetModulesByUserId(int id);
    }
}
