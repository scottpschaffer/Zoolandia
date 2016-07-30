using System;

    namespace Zoolandia.Species
    {
        public class Abelii : Pongo
        {
            public string Color;
            public string commonName = "Orangutan";

            public Abelii(string name) : base(name)
            {
                this.Color = "orange";
                this.Weight = 320;
                this.Height = 6.5F;
            }

            public override String Eat(int numBananas)
            {
                return "I eat " + numBananas + " Bananas per day!";
            }
        }

    }