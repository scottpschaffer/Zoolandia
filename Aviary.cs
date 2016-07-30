using System;

namespace Zoolandia
{
    class Aviary : Habitat, IAnimalHabitat
    {
        public void AddA(Animal resident)
        {
            this.inhabitants.Add(resident);
        }

        public string Feeding()
        {
            string output = "";
            foreach (var animal in inhabitants)
            {
                output += "Feeding " + animal.Name + ":" + animal.Eat(5) + "  \r\n";
            }

            return output;
        }

        public string Performance()
        {
            string output = "";
            foreach (var animal in inhabitants)
            {
                output += "Here comes " + animal.Name + " the dancing " + animal.GetType() + "\r\n";
            }

            return output;
        }
    }
}