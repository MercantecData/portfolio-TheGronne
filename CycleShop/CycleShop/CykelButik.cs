using System;
using System.Collections.Generic;
using System.Text;

namespace CykelOpgave
{
    class CykelButik
    {
        public List<Cykel> cykler = new List<Cykel>();



        public CykelButik()
        {

        }


        public string tilføjCykler()
        {
            cykler.Add(new Cykel("BMW", 10, "Grey", "Male", "City"));
            return (cykler[0].colour);
        }
        public string manifacturers()
        {
            return cykler[0].manifacturer;
        }

    }
}
