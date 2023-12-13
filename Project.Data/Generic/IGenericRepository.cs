using System.Collections.Generic;

namespace Project.Data.Generic
{
    public interface IGenericRepository<T> where T : class
    {
        bool Create(T entity);
        bool Update(T entity);
        T Get(int id);
        IEnumerable<T> GetAll();
        bool Delete(int id);
    }
}
