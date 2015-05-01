using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using OnlineStore.ServiceContracts;
using OnlineStore.Domain.Model;
using OnlineStore.Domain.Repositories;
using OnlineStore.Infrastructure;

namespace OnlineStore.Application
{
    // 商品WCF服务
    public class ProductService : IProductService
    {
        // 引用商品服务接口
        private readonly IProductService _productService;

        public ProductService()
        {
            _productService = ServiceLocator.Instance.GetService<IProductService>();
        }

        public IEnumerable<Product> GetProducts()
        {
            return _productService.GetProducts();
        }

        public IEnumerable<Product> GetNewProducts(int count)
        {
            return _productService.GetNewProducts(count);
        }

        public IEnumerable<Category> GetCategories()
        {
            return _productService.GetCategories();
        }

        public Product GetProductById(Guid id)
        {
            return _productService.GetProductById(id);
        }
    }
}
