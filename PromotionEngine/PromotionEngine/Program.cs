using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductRepo;

namespace ConsoleApp1
{
    class Program
    {
       static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            ProductService objprod = new ProductService();
            Console.WriteLine("total number of order");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {                
                Console.WriteLine("enter the type of product:A,B,C or D");
                string type= Console.ReadLine();
                Product p = new Product(type);
                products.Add(p);
            }

            int totalPrice = objprod.GetTotalPrice(products);
            Console.WriteLine("Total Price:" +totalPrice);
            Console.ReadLine();
        }
    }
};
    

