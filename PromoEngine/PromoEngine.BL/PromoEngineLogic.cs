using PromoEngine.PromoEngine.Interfaces;
using PromoEngine.PromoEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PromoEngine.PromoEngine.BL
{
    public class PromoEngineLogic : IPromoEngineLogic
    {
        public double GetTotalPrice(List<Product> products)
        {
            try
            {
                int countofA = 0;
                double priceofA = 50;
                int countofB = 0;
                double priceofB = 30;
                int CountofC = 0;
                double priceofC = 20;
                int CountofD = 0;
                double priceofD = 15;
                foreach (Product pr in products)
                {
                    if (pr.Id.ToLower() == "a")
                    {
                        countofA = countofA + 1;
                    }
                    if (pr.Id.ToLower() == "b")
                    {
                        countofB = countofB + 1;
                    }
                    if (pr.Id.ToLower() == "c")
                    {
                        CountofC = CountofC + 1;
                    }
                    if (pr.Id.ToLower() == "d")
                    {
                        CountofD = CountofD + 1;
                    }
                }

                double totalPriceofA = GetTotalPriceofA(countofA, priceofA);

                double totalPriceofB = GetTotalPriceofB(countofB, priceofB);

                bool isExists = ListContainsOneCOneD(products);

                double totalPriceofC = 0;
                double totalPriceofD = 0;
                double totalPriceofCD = 0;
                if (isExists)
                {
                    totalPriceofCD = 30;
                }
                else
                {
                    totalPriceofC = (CountofC * priceofC);
                    totalPriceofD = (CountofD * priceofD);
                }

                return totalPriceofA + totalPriceofB + totalPriceofC + totalPriceofD + totalPriceofCD;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool ListContainsOneCOneD(List<Product> productList)
        {
            if ((productList.Where(x => x.Id.ToLower() == "c").Count() == 1) & (productList.Where(x => x.Id.ToLower() == "d").Count() == 1))
            {
                return true;
            }
            return false;
        }

        private static double GetTotalPriceofB(int countofB, double priceofB)
        {
            double totalPriceofB = 0;
            if (countofB > 2)
            {
                int res = countofB / 2;
                int remainProducts = countofB - (res * 2);
                for (int i = 1; i <= res; i++)
                {
                    totalPriceofB += 45;
                }
                totalPriceofB += remainProducts * priceofB;
            }
            else if (countofB == 2)
            {
                totalPriceofB += ((countofB / 2) * 45 + (countofB % 2 * priceofB));
            }
            else
            {
                totalPriceofB += countofB * priceofB;
            }

            return totalPriceofB;
        }

        private static double GetTotalPriceofA(int countofA, double priceofA)
        {
            double totalPriceofA = 0;


            if (countofA > 3)
            {
                int res = countofA / 3;
                int remainProducts = countofA - (res * 3);
                for (int i = 1; i <= res; i++)
                {
                    totalPriceofA += 130;
                }
                totalPriceofA += remainProducts * priceofA;
            }
            else if (countofA == 3)
            {
                totalPriceofA += ((countofA / 3) * 130 + (countofA % 3 * priceofA));
            }
            else
            {
                totalPriceofA += countofA * priceofA;
            }

            return totalPriceofA;
        }
    }
}
