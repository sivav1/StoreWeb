using StoreWeb.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace StoreWeb.Repo
{
    public class ProductsRepo: BaseRepo<Product>
    {
        static string productsXml = Path.Combine(HttpContext.Current.Request.PhysicalApplicationPath, @"App_Data\Products.xml");

        public ProductsRepo() : base(productsXml, "Products")
        {

        }

        public List<Product> GetProducts()
        {
            return ObjectsList;
        }

        public Product GetProduct(int productId)
        {
            Product product = null;
            if (ObjectsList != null)
            {
                product = ObjectsList.FirstOrDefault(p => p.Id == productId);
            }
            return product;
        }
    }
}