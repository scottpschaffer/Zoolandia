using System;

    namespace Zoolandia.Species
    {
        public class Buthus : Animal
        {
            
            public Buthus(string name) : base(name)
            {
                this.Feet = 8;
                this.Tail = true;
            }

            public override String Move(int distance)
            {
                return "I crawled " + distance + " meters! And are my legs tired! Oy!";
            }
        }

    }