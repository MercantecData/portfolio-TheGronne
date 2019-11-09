using System;
using System.Collections.Generic;

namespace CykelOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sup");
            Console.WriteLine("Write 1 to see all bycicle stats");
            Console.WriteLine("Write 2 to buy a bycicle");
            Console.WriteLine("Write 3 to search for a bycicle");
            CykelButik nyCykel = new CykelButik();
            Console.WriteLine("Which bycicle do you want?");
            nyCykel.tilføjCykler();
        }
    }
}
