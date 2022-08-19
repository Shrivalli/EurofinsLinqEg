using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEg
{
    class prdclient
    {
        public static List<Product> products = Product.getAllPrds();
        public static void DisplayProducts()
        {
            foreach(var item in products)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void DisplayPartPrd()
        {
            Console.WriteLine("Enter the product ID");
            int id = Convert.ToInt32(Console.ReadLine());
            Product p=Product.getPrdById(id);
            Console.WriteLine(p.ToString());
        }
        public static void Main()
        {
            DisplayProducts();
            DisplayPartPrd();
        }
    }
}
