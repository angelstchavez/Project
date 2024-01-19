using Project.Data.Generic;
using Project.Data.Interface;
using Project.Data.Repository;
using Project.Entity;
using System.Collections.Generic;

namespace Project.Business.Services
{
    public class SaleService : ISaleRepository
    {
        private readonly SaleRepository saleRepository;

        public SaleService()
        {
            this.saleRepository = new SaleRepository();
        }

        public int Create(Sale entity)
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

        public decimal GetCashSalesForToday()
        {
            return saleRepository.GetCashSalesForToday();
        }

        public decimal GetDaviplataSalesForToday()
        {
            return saleRepository.GetDaviplataSalesForToday();
        }

        public decimal GetNequiSalesForToday()
        {
            return saleRepository.GetNequiSalesForToday();
        }

        public IEnumerable<DetailedProduct> GetProductSalesForToday()
        {
            return saleRepository.GetProductSalesForToday();
        }

        public IEnumerable<DetailedSale> GetSalesForToday()
        {
            return saleRepository.GetSalesForToday();
        }

        public IEnumerable<SalePerDay> GetTotalSalesPerDay()
        {
            return saleRepository.GetTotalSalesPerDay();
        }

        public bool Update(Sale entity)
        {
            return saleRepository.Update(entity);
        }

        bool IGenericRepository<Sale>.Create(Sale entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
