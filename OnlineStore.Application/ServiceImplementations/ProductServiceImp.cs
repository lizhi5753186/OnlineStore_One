using System;
using System.Collections.Generic;
using OnlineStore.Domain.Model;
using OnlineStore.Domain.Repositories;
using OnlineStore.ServiceContracts;

namespace OnlineStore.Application.ServiceImplementations
{
    // 商品服务的实现
    public class ProductServiceImp : IProductService
    {
        #region Private Fields
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        #endregion 

        #region Ctor
        public ProductServiceImp(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
        }

        #endregion

        #region IProductService Members
        public IEnumerable<Product> GetProducts()
        {
            return _productRepository.GetAll();
        }

        public IEnumerable<Product> GetNewProducts(int count)
        {
            return _productRepository.GetNewProducts(count);
        }

        public IEnumerable<Category> GetCategories()
        {
            return _categoryRepository.GetAll();
        }

        public Product GetProductById(Guid id)
        {
            var product = _productRepository.GetByKey(id);
            return product;
        }

        #endregion  
    }
}