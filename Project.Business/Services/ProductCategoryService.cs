using Project.Data.Interface;
using Project.Data.Repository;
using Project.Entity;
using System.Collections.Generic;

namespace Project.Business.Services
{
    public class ProductCategoryService
    {
        private readonly IProductCategoryRepository productCategoryRepository;

        public ProductCategoryService()
        {
            this.productCategoryRepository = new ProductCategoryRepository();
        }

        public bool Create(ProductCategory category)
        {
            return productCategoryRepository.Create(category);
        }

        public bool Delete(int id)
        {
            return productCategoryRepository.Delete(id);
        }

        public ProductCategory Get(int id)
        {
            return productCategoryRepository.Get(id);
        }

        public IEnumerable<ProductCategory> GetAll()
        {
            return productCategoryRepository.GetAll();
        }

        public bool Update(ProductCategory category)
        {
            return productCategoryRepository.Update(category);
        }
    }
}
