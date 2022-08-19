using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEg
{
    // A comment from Hamza Rarani
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

        public static void AddNewPrd()
        {
            Console.WriteLine("Enter Pid, Pname and Price");
            Product p = new Product();
            p.Pid = Convert.ToInt32(Console.ReadLine());
            p.Pname = Console.ReadLine();
            p.Price = float.Parse(Console.ReadLine());
            Product.AddProduct(p);
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
           
            //DisplayPartPrd();
            AddNewPrd();
            DisplayProducts();
        }
    }
}
