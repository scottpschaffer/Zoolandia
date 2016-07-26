using System;

    namespace Zoolandia.Species
    {
        public class Fulgens : Ailurus
        {
            public string commonName = "Red Panda";
            public string scientificName = "Ailurus Fulgens";
            public string Color;

            public Fulgens(string name) : base(name)
            {
                this.Color = "red";
            }

            public override string Eat()
            {
                return "I eat Bamboo and leaves. Aw yeah!";
            }
        }
    }