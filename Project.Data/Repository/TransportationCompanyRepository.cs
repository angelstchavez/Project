using Project.Data.Connection;
using Project.Data.Interface;
using Project.Entity;
using System.Collections.Generic;

namespace Project.Data.Repository
{
    public class TransportationCompanyRepository : ITransportationCompanyRepository
    {
        private readonly string ConnectionString;

        public TransportationCompanyRepository()
        {
            ConnectionString = MasterConnection.ConnectionString;
        }

        public bool Create(TransportationCompany entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public TransportationCompany Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TransportationCompany> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public bool Update(TransportationCompany entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
