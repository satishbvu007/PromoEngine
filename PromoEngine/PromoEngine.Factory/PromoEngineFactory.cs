using PromoEngine.PromoEngine.BL;
using PromoEngine.PromoEngine.Interfaces;

namespace PromoEngine.PromoEngine.Factory
{
   public class PromoEngineFactory
    {
        private IPromoEngineLogic promoEngineLogicObj;
        public IPromoEngineLogic GetInstance()
        {
            promoEngineLogicObj = new PromoEngineLogic();
            return promoEngineLogicObj;
        }
    }
}
