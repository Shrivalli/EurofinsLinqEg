using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqEg
{//Language Integrated Query
    //1. Native query language
    //2. Data source - any (LINQ to XML, LINQ to Entites, LINQ to SQL, LINQ to collections, LINQ to objects)
    //2 syntax in LINQ - query syntax, method syntax
    class Program
    {
        
        static void main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(50);
            numbers.Add(80);
            numbers.Add(12);
            numbers.Add(23);
            //Query syntax
            var result=(from i in numbers
                       where i>45
                       select i).ToList();
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }

            //Method syntax
            Console.WriteLine(" Method syntax output ");
            var resnumbers = numbers.Where(x => x > 45).Select(x => x);
            foreach(var item in resnumbers)
            {
                Console.WriteLine(item);
            }
            List<string> fruits = new List<string>();
            fruits.Add("Avacado");
            fruits.Add("Banana");
            fruits.Add("Kiwi");
            fruits.Add("Apple");
            fruits.Add("Cherry");
            fruits.Add("Apricot");
            fruits.Add("Oranges");
            var res = (from i in fruits
                       where i.StartsWith('A')
                       select i).ToList();
            foreach(var item in res)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(" Method syntax output ");
            //method syntax
            var resfruits = fruits.Where(a => a.StartsWith('A')).Select(a => a);
            foreach(var item in resfruits)
            {
                Console.WriteLine(item);
            }
        }
    }
}
