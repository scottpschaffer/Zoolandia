using System;

    namespace Zoolandia.Species
    {
        public class Bicornis : Diceros
        {
            public string commonName = "Black Rhino";
            public string scientificName = "Diceros Bicornis";

            public Bicornis(string name) : base(name)
            {
                
            }

            public Bicornis(int cutenessFactor, string name) : base(name)
            {

            }

        }
    }