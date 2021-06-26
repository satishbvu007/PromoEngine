using PromoEngine.PromoEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromoEngine.PromoEngine.Interfaces
{
   public interface IProductRepository
    {
        Product GetProductDetailsById(string productId);
    }
}
