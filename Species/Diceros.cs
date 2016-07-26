using System;

    namespace Zoolandia.Species
    {
        public class Diceros : Animal
        {
            public int horns = 2;

            public Diceros(string name) : base(name)
            {
                this.Tail = true;
                Random r = new Random();
                this.Weight = r.Next(1800, 3100);
                this.Height = (float)(r.Next(4, 6));
                this.Feet = 4;
            }

            public Diceros(int cutenessFactor, string name) : base(name)
            {
                this.Tail = true;
                Random r = new Random();
                this.Weight = r.Next(1800, 3100);
                this.Height = (float)(r.Next(4, 6));
                this.Feet = 4;
                CutenessFactor = cutenessFactor;
            }

            public int CutenessFactor {get; set;}

            public override string Eat(int numberOfFoodZ)
            {
                
                return "I am a herbivore and I eat " + numberOfFoodZ + " times a day. " + base.Eat(numberOfFoodZ);
            }

            public override string Move(int distance)
            {
                return this.Name + " has walked " + distance.ToString() + " miles.";
            }

            public string Welcome()
            {
                return "Welcome " + this.Name;
            }
        }

    }