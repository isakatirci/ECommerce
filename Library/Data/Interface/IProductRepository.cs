using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Interface
{
    public interface IProductRepository
    {
        ICollection<Product> GetProductList();
    }
}
