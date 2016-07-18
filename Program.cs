using System;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AilurusFulgens redPanda = new AilurusFulgens("Steve");
            redPanda.Name = "Steve";
            string response = redPanda.Eat(5);

            Console.WriteLine(redPanda.Name + " says " + response);
            
            
            AilurusFulgens Joe = new AilurusFulgens("Steve");
            Console.WriteLine(Joe.Welcome("Joe"));
            Console.WriteLine(Joe.Name);
            Console.WriteLine(Joe.Name + " Weighs " + Joe.Weight + " lbs.");
            Console.WriteLine(Joe.Name + " is " + Joe.Height + " inches long.");
            Console.WriteLine("Is it true that " + Joe.Name + " has a tail? " + Joe.Tail.ToString());
            Console.WriteLine(Joe.Name + "is " + Joe.Color);
            Console.WriteLine(Joe.Move(23));
            Console.ReadLine();

            DicerosBicornis rhino = new DicerosBicornis("Fred");
            rhino.Welcome();
            Console.WriteLine(rhino.Name + " Weighs " + rhino.Weight + " lbs.");
            Console.WriteLine(rhino.Name + " is " + rhino.Height + " feet long.");
            Console.WriteLine("Is it true that " + rhino.Name + " has a tail? " + rhino.Tail.ToString());
            Console.WriteLine(rhino.Name + " has " + rhino.horns + " horns");
            Console.WriteLine(rhino.Move(11));
            Console.WriteLine(rhino.Eat(5));

            GorillaBeringeiBeringei Ape = new GorillaBeringeiBeringei("Mike");
            Console.WriteLine(Ape.Welcome());
            Console.WriteLine(Ape.Name + " Weighs " + Ape.Weight + " lbs.");
            Console.WriteLine(Ape.Name + " is " + Ape.Height + " feet long.");
            Console.WriteLine("Is it true that " + Ape.Name + " has a tail? " + Ape.Tail.ToString());
            Console.WriteLine(Ape.Name + " has " + Ape.fingers + " fingers on each hand");
            Console.WriteLine(Ape.Move(33));
            Console.WriteLine(Ape.Eat(2));
            
            BalaenopteraMusculus whale = new BalaenopteraMusculus("Andrea");
            Console.WriteLine(whale.Welcome());
            Console.WriteLine(whale.Name + " Weighs " + whale.Weight + " lbs.");
            Console.WriteLine(whale.Name + " is " + whale.Height + " feet long.");
            Console.WriteLine("Is it true that " + whale.Name + " has a tail? " + whale.Tail.ToString());
            Console.WriteLine(whale.Name + " has " + whale.fins + " fins ");
            Console.WriteLine(whale.Move(444));
            Console.WriteLine(whale.Eat(200));
        }
    }
}
