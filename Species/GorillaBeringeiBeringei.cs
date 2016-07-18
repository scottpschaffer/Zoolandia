using System;

    namespace Zoolandia.Species
    {
        
        public class GorillaBeringeiBeringei : Animal
        {
            public int fingers = 5;

            public GorillaBeringeiBeringei(string name) : base(name)
            {
                this.Tail = false;
                Random r = new Random();
                this.Weight = r.Next(300, 400);
                this.Height = (float)(r.Next(5, 6));
                this.Feet = 2;
            }
            public override string Eat(int numberOfFoodZ)
            {
                
                return "I am a herbivore and I eat " + numberOfFoodZ + " bananas a day. " + base.Eat(numberOfFoodZ);
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