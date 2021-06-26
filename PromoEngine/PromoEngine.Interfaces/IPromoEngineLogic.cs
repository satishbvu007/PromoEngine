using PromoEngine.PromoEngine.Models;
using System.Collections.Generic;


namespace PromoEngine.PromoEngine.Interfaces
{
   public interface IPromoEngineLogic
    {
        double GetTotalProductsPrice(List<Product> products);
        Product GetProductById(string id);
    }
}
