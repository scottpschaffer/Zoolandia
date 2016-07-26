using System;

    namespace Zoolandia.Species
    {
        public class Musculus : Balaenoptera
        {
            public string commonName = "Blue Whale";
            public string scientificName = "Balaenoptera Musculus";

            public Musculus(string name) : base(name)
            {
                
            }

            public Musculus(int cutenessFactor, string name) : base(name)
            {

            }
        }
    }