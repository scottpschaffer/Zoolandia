using System;

    namespace Zoolandia.Species
    {
        public class Occitanus : Buthus
        {
            public String Color;
            public string commonName = "Scorpion";

            public Occitanus(string name) : base(name)
            {
                this.Color = "Yellow";
                this.Weight = 30;
                this.Height = 76.4F;
            }

            public override String Eat(int numFoods)
            {
                return "I eat " + numFoods + " insects per day!";
            }

        }

    }