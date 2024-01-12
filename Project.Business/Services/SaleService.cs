using Project.Data.Interface;
using Project.Entity;
using System.Collections.Generic;

namespace Project.Business.Services
{
    public class SaleService : ISaleRepository
    {
        private readonly ISaleRepository saleRepository;

        public SaleService(ISaleRepository saleRepository)
        {
            this.saleRepository = saleRepository;
        }

        public bool Create(Sale entity)
        {
            return saleRepository.Create(entity);
        }

        public bool Delete(int id)
        {
            return saleRepository.Delete(id);
        }

        public Sale Get(int id)
        {
            return saleRepository.Get(id);
        }

        public IEnumerable<Sale> GetAll()
        {
            return saleRepository.GetAll();
        }

        public bool Update(Sale entity)
        {
            return saleRepository.Update(entity);
        }
    }
}
