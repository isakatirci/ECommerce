using BlazorUI.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorUI.Client.Services
{
    public class ProductService : BaseService
    {
        public ProductService(HttpClient httpClient) : base(httpClient)
        {

        }

        public IList<ProductModel> Products { get; set; }

        public async Task GetProductList()
        {
            var products = await Get<List<ProductModel>>("api/Product");

            Products = products;
        }

    }
}
