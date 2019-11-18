using System;
using System.Collections.Generic;

namespace CykelOpgave
{
    class Program
    {
        
        static void Main(string[] args)
        {
            CykelButik JørgenHansen = new CykelButik();
            Console.WriteLine(JørgenHansen.CykelList1[0].manifacturer);

            int i = 0;
            foreach (var cykel in JørgenHansen.CykelList1)
            {
                Console.WriteLine(i + ". manufacture" + cykel.manifacturer + " Color: " + cykel.colour);
                i += 1;
            }





            Console.WriteLine("Sup");
            Console.WriteLine("Write 1 to see all bycicle manifacturers");
            Console.WriteLine("Write 2 to buy a bycicle");
            Console.WriteLine("Write 3 to search for a bycicle");
            
            Console.WriteLine("Which bycicle do you want?");


        }
    }
}
