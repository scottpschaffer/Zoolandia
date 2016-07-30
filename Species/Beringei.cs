using System;

    namespace Zoolandia.Species
    {
        public class Beringei : Gorilla
        {

            public string commonName = "Mountain Gorilla";
            public Beringei(string name) : base(name)
            {
                
            }

            public Beringei(int teeth) : base(teeth)
            {

            }
        }
    }