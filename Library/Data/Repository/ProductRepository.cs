using Data.Interface;
using Data.UnitOfWork;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly IUnitOfWork _uow;

        public ProductRepository(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public ICollection<Product> GetProductList()
        {
            return _uow.Product.TableNoTracking.ToList();
        }
    }
}
