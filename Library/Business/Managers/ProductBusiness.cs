using Business.Interfaces;
using Data.Interface;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Managers
{
    public class ProductBusiness : IProductBusiness
    {
        private readonly IProductRepository _productRepository;

        public ProductBusiness(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ICollection<Product> GetProductList()
        {
            return _productRepository.GetProductList();
        }
    }
}
