using System;
using System.Collections.Generic;
using System.Text;

namespace CykelOpgave
{
    class CykelButik
    {
        public int maxCykler = 50;
        public string[] cykler;
        int arrayNumber;

        public CykelButik(string[] cykler, int arrayNumber)
        {
            cykler = new string[maxCykler];
            this.cykler = cykler;
            this.arrayNumber = arrayNumber;
        }

        public string alleCykler()
        {
              while (arrayNumber < maxCykler)
              {
                return manifacturer[arrayNumber];
                
              }  
        }

        public string tilføjCykler()
        {
            
        }
    }
}
