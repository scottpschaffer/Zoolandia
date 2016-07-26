using System;

    namespace Zoolandia.Species
    {
        public class Pongo : Animal
        {
            
            public Pongo(string name) : base(name)
            {
                this.Feet = 6;
                this.Tail = false;
            }

            public override String Move(int distance)
            {
                return "I shuffled " + distance + " miles! And are my arms tired!";
            }
        }

    }