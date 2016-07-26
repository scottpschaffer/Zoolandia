using System;

    namespace Zoolandia.Species
    {
        public class Alligator : Animal
        {
            
            public Alligator(string name) : base(name)
            {
                this.Feet = 4;
                this.Tail = true;

            }
            public override String Move(int distance)
            {
                return "I swam " + distance + " miles! So watch out!";
            }
        }

    }