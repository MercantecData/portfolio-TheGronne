using System;
using System.Collections.Generic;
using System.Text;

namespace CykelOpgave
{
    class CykelButik
    {
        public List<Cykel> CykelList1 = new List<Cykel>();
        //public int maxCykler = 3;
        //public string[] cykler;
        //int arrayNumber;
        public CykelButik()
        {

        }

        public void AddCukel()
        {
            CykelList1.Add(new Cykel("Mercedes", 27.5, "Red", "Hermofordit", "City"));
            CykelList1.Add(new Cykel("Mercedes", 27.5, "Red", "Hermofordit", "City"));
            CykelList1.Add(new Cykel("Mercedes", 27.5, "Red", "Hermofordit", "City"));
            CykelList1.Add(new Cykel("Mercedes", 27.5, "Red", "Hermofordit", "City"));
            CykelList1.Add(new Cykel("Mercedes", 27.5, "Red", "Hermofordit", "City"));
            CykelList1.Add(new Cykel("Mercedes", 27.5, "Red", "Hermofordit", "City"));
            CykelList1.Add(new Cykel("Mercedes", 27.5, "Red", "Hermofordit", "City"));

        }
        //public string manifacturers()
        //{
        //    cykler[0] = "BMW";
        //    cykler[1] = "ferrari";
        //    cykler[2] = "LED";

        //    while (arrayNumber < cykler.Length)
        //    {
        //        return cykler[arrayNumber];
        //        arrayNumber++;
        //    }

        //    return cykler[arrayNumber];
        //    arrayNumber = 0;
        //}
    }
}
