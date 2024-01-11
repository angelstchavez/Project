using Project.Data.Interface;
using Project.Data.Repository;
using Project.Entity;
using System.Collections.Generic;

namespace Project.Business.Services
{
    public class CustomerService : ICustomerRepository
    {
        private readonly CustomerRepository customerRepository;

        public CustomerService()
        {
            this.customerRepository = new CustomerRepository();
        }

        public bool Create(Customer entity)
        {
            return customerRepository.Create(entity);
        }

        public bool Delete(int id)
        {
            return customerRepository.Delete(id);
        }

        public Customer Get(int id)
        {
            return customerRepository.Get(id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return customerRepository.GetAll();
        }

        public Customer GetByPhoneNumber(string phoneNumber)
        {
            return customerRepository.GetByPhoneNumber(phoneNumber);
        }

        public IEnumerable<Customer> GetPagedCustomers(int pageSize, int pageNumber)
        {
            return customerRepository.GetPagedCustomers(pageSize, pageNumber);
        }

        public int GetTotalCustomerCount()
        {
            return this.customerRepository.GetTotalCustomerCount();
        }

        public bool Update(Customer entity)
        {
            return customerRepository.Update(entity);
        }
    }
}
