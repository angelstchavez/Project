using Project.Data.Interface;
using Project.Data.Repository;
using Project.Entity;
using System.Collections.Generic;
using System.Globalization;

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
            // Capitalizar el nombre antes de crear el cliente
            entity.Name = CapitalizeName(entity.Name);

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

        public int GetCustomerCountForToday()
        {
            return customerRepository.GetCustomerCountForToday();
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
            // Capitalizar el nombre antes de actualizar el cliente
            entity.Name = CapitalizeName(entity.Name);

            return customerRepository.Update(entity);
        }

        private string CapitalizeName(string name)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.ToLower());
        }
    }
}
