using System;

    namespace Zoolandia.Species
    {
        public class DicerosBicornis : Animal
        {
            public int horns = 2;

            public DicerosBicornis(string name) : base(name)
            {
                this.Tail = true;
                Random r = new Random();
                this.Weight = r.Next(1800, 3100);
                this.Height = (float)(r.Next(4, 6));
                this.Feet = 4;
            }
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