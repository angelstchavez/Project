using Project.Data.Interface;
using Project.Data.Repository;
using Project.Entity;
using System.Collections.Generic;

namespace Project.Business.Services
{
    public class TransportationCompanyService : ITransportationCompanyRepository
    {
        private readonly TransportationCompanyRepository transportationCompanyRepository;

        public TransportationCompanyService()
        {
            this.transportationCompanyRepository = new TransportationCompanyRepository();
        }

        public bool Create(TransportationCompany entity)
        {
            return transportationCompanyRepository.Create(entity);
        }

        public bool Delete(int id)
        {
            return transportationCompanyRepository.Delete(id);
        }

        public TransportationCompany Get(int id)
        {
            return transportationCompanyRepository.Get(id);
        }

        public IEnumerable<TransportationCompany> GetAll()
        {
            return transportationCompanyRepository.GetAll();
        }

        public bool Update(TransportationCompany entity)
        {
            return transportationCompanyRepository.Update(entity);
        }
    }
}
