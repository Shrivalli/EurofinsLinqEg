using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEg
{
    class Product
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public float Price { get; set; }

        public Product() { }
        public Product(int pid,string pname,float price)
        {
            Pid = pid;
            Pname = pname;
            Price = price;
        }

        public static List<Product> prds = new List<Product>();
        public static List<Product> getAllPrds()
        {
            prds.Add(new Product(1, "Pen", 34));
            prds.Add(new Product(2, "Erasor", 20));
            prds.Add(new Product(3, "Pencil", 90));
            return prds;

        }

        public static Product getPrdById(int id)
        {
            //Product p = (from i in prds
            //             where i.Pid == id
            //             select i).SingleOrDefault();
            Product p = prds.Where(x => x.Pid == id).Select(x => x).SingleOrDefault();
            return p;
        }

        public override string ToString()
        {
            return string.Format(Pid + " " + Pname + " "+Price);
        }
    }
}
