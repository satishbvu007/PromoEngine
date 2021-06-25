using PromoEngine.PromoEngine.Models;
using System.Collections.Generic;


namespace PromoEngine.PromoEngine.Interfaces
{
   public interface IPromoEngineLogic
    {
        double GetTotalPrice(List<Product> products);
    }
}
