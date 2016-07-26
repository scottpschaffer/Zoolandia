using System;

    namespace Zoolandia.Species
    {
        public class Mississippiensis : Alligator
        {
            public String Color;

            public Mississippiensis(string name) : base(name)
            {
                this.Color = "Green";
                this.Weight = 210;
                this.Height = 10.4F;
            }

            public override String Eat(int numFoods)
            {
                return "I eat " + numFoods + " People per day!";
            }

        }

    }