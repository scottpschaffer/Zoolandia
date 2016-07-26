using System;

    namespace Zoolandia.Species
    {
        
        public class Balaenoptera : Animal
        {
            public int fins = 2;

            public Balaenoptera(string name) : base(name)
            {
                this.Tail = true;
                this.Weight = 300000;
                this.Height = 98;
                this.Feet = 0;
            }

            public override string Eat(int numberOfFoodZ)
            {
                
                return "I am a carnivore and I eat " + numberOfFoodZ + " fish a day. " + base.Eat(numberOfFoodZ);
            }

            public override string Move(int distance)
            {
                return this.Name + " has swam " + distance.ToString() + " miles.";
            }

            public string Welcome()
            {
                return "Welcome " + this.Name;
            }
        }

    }