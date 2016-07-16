using System;

namespace Zoolandia
{
    public class Animal
    {
        public Animal(string name)
        {
            this.Name = name;
        }
        public string Name {get; set;}

        public virtual string Eat(int numberOfFoodz)
        {
            return "YUM!";
        }
    }
}