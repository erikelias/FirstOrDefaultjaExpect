
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ");

            //kutsume WhereLINQ meetodi välja
            
            FirstOrDefault();
            Except();
        }



        public static void FirstOrDefault()
        {
            //se tagastab jada esimese elemendi või vaikeväärtuse, kui jada elemente ei sisalda
            Console.WriteLine("First or Default");

            var firstOrDefault = NumberList.numberList.LastOrDefault();

            Console.WriteLine(firstOrDefault);
        }
        public static void Except()
        {
            //se tagastab kahe jada erinevuse see tagastab jada, mis sisaldab esimese jada elemente, mida teises jadas ei ole
            IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            IList<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };

            var result = strList1.Except(strList2);

            foreach (var item in result)
            {
                Console.WriteLine("Except: " + item);
            }
        }
    }
}
