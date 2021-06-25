using System;
using System.Collections.Generic;
using PromoEngine.PromoEngine.Models;
using PromoEngine.PromoEngine.Factory;

namespace PromoEngine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                List<Product> products = new List<Product>();
                Console.WriteLine("total number of order");
                int a = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < a; i++)
                {
                    Console.WriteLine("enter the type of product:A,B,C or D");
                    string type = Console.ReadLine();
                    Product p = new Product(type);
                    products.Add(p);
                }
                PromoEngineFactory factoryObj = new PromoEngineFactory();
                double totalPrice = factoryObj.GetInstance().GetTotalPrice(products);
                Console.WriteLine(totalPrice);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
