using System;
using System.Collections.Generic;
using System.Text;

namespace CykelOpgave
{
    class CykelButik
    {

        public List<Cykel> cykler = new List<Cykel>();
        public void tilføjCykler()
        {
            cykler.Add(new Cykel("BMW", 10, "Grey", "Male", "City"));
            Console.WriteLine(cykler[0]);
        }
        public string manifacturers()
        {
            return cykler[0].manifacturer;
        }
    }
}
