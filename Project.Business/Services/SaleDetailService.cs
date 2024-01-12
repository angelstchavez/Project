using Project.Data.Interface;
using Project.Data.Repository;
using Project.Entity;
using System.Collections.Generic;

namespace Project.Business.Services
{
    public class SaleDetailService : ISaleDetailRepository
    {
        private readonly SaleDetailRepository saleDetailRepository;

        public SaleDetailService()
        {
            this.saleDetailRepository = new SaleDetailRepository();
        }

        public bool Create(SaleDetail entity)
        {
            return saleDetailRepository.Create(entity);
        }

        public bool Delete(int id)
        {
            return saleDetailRepository.Delete(id);
        }

        public SaleDetail Get(int id)
        {
            return saleDetailRepository.Get(id);
        }

        public IEnumerable<SaleDetail> GetAll()
        {
            return saleDetailRepository.GetAll();
        }

        public bool Update(SaleDetail entity)
        {
            return saleDetailRepository.Update(entity);
        }
    }
}
