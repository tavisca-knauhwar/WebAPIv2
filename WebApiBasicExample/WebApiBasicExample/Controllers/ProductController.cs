using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiBasicExample.Controllers
{
    public class ProductController : ApiController
    {
        private static List<Models.Product> _productList = InitProductList();

        private static List<Models.Product> InitProductList()
        {
            var products = new List<Models.Product>();

            products.Add(new Models.Product() { Id = 1, Name = "Indian" });
            products.Add(new Models.Product() { Id = 2, Name = "Chinese" });
            products.Add(new Models.Product() { Id = 3, Name = "Thai" });
            products.Add(new Models.Product() { Id = 4, Name = "Malay" });

            return products;

        }
        [HttpGet]
        public List<Models.Product> FetchAllProducts()
        {
            return _productList;
        }
    }
}
