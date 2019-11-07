using System;
using System.Collections.Generic;
using System.Text;

namespace CykelOpgave
{
    class Cykel
    {
        public string manifacturer;
        public double wheelSize;
        public string colour;
        public string gender;
        public string terrain;

        public Cykel(string manifacturer, double wheelSize, string colour, string gender, string terrain)
        {
            this.manifacturer = manifacturer;
            this.wheelSize = wheelSize;
            this.colour = colour;
            this.gender = gender;
            this.terrain = terrain;
        }
    }
}
