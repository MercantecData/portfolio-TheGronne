using System;
using System.Collections.Generic;

namespace CykelOpgave
{
    class Program
    {
        
        static void Main(string[] args)
        {
            CykelButik nyCykel = new CykelButik();
            Console.WriteLine("Which bycicle do you want?");


            nyCykel.manifacturers();
            nyCykel.tilføjCykler();
        }
    }
}
