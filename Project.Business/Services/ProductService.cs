using Project.Data.Repository;
using Project.Entity;
using System.Collections.Generic;

namespace Project.Business.Services
{
    public class ProductService
    {
        private readonly ProductRepository productRepository;

        public ProductService()
        {
            this.productRepository = new ProductRepository();
        }

        public bool Create(Product product)
        {
            return productRepository.Create(product);
        }

        public bool Delete(int id)
        {
            return productRepository.Delete(id);
        }

        public Product Get(int id)
        {
            return productRepository.Get(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return productRepository.GetAll();
        }

        public IEnumerable<Product> GetActiveProductsByCategoryId(int categoryId)
        {
            return productRepository.GetByCategoryId(categoryId);
        }

        public bool Update(Product product)
        {
            return productRepository.Update(product);
        }
    }
}
