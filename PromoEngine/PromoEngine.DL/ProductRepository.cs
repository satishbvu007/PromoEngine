using PromoEngine.PromoEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromoEngine.PromoEngine.Models;

namespace PromoEngine.PromoEngine.DL
{
    public class ProductRepository : IProductRepository
    {
        public Product GetProductDetailsById(string productId)
        {
            try
            {

           
            if (string.IsNullOrWhiteSpace(productId))
                throw new Exception("Invalid product");

            Product objProduct = new Product();
            objProduct.Id = productId;
            switch (productId.ToUpper())
            {
                case "A":
                    objProduct.Price = 50m;

                    break;
                case "B":
                    objProduct.Price = 30m;

                    break;
                case "C":
                    objProduct.Price = 20m;

                    break;
                case "D":
                    objProduct.Price = 15m;
                    break;
                default:
                    throw new Exception("Invalid product selected");
            }
            return objProduct;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
