using System;
using System.Collections.Generic;

namespace CykelOpgave
{
    class Program
    {
        
        static void Main(string[] args)
        {
            CykelButik nyCykel = new CykelButik();

            nyCykel.manifacturers();
            nyCykel.tilføjCykler();
        }
    }
}
