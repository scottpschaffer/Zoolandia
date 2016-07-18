using System;

namespace Zoolandia
{
    public class Animal
    {
        public Animal(string name)
        {
            this.Name = name;
        }
        public bool Tail {get; set;}
        public string Name {get; set;}
        public int Weight {get; set;}
        public float Height {get; set;}
        public int Feet {get; set;}

        public virtual string Move(int distance)
        {
            return this.Name + " has moved " + distance.ToString() + " miles.";
        }

        public virtual string Eat(int numberOfFoodz)
        {
            return "YUM!";
        }

        public string Sleep()
        {
            return this.Name + " is now sleeping";
        }


    }
}