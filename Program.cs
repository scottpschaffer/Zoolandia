using System;
using Zoolandia.Species;
using System.IO;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Fulgens redPanda = new Fulgens("Steve");
            redPanda.Name = "Steve";
            string response = redPanda.Eat(5);

            Console.WriteLine(redPanda.Name + " says " + response);
            
            
            Fulgens Joe = new Fulgens("Steve");
            Console.WriteLine(Joe.Welcome("Joe"));
            Console.WriteLine(Joe.Name);
            Console.WriteLine(Joe.Name + " Weighs " + Joe.Weight + " lbs.");
            Console.WriteLine(Joe.Name + " is " + Joe.Height + " inches long.");
            Console.WriteLine("Is it true that " + Joe.Name + " has a tail? " + Joe.Tail.ToString());
            Console.WriteLine(Joe.Name + "is " + Joe.Color);
            Console.WriteLine(Joe.Move(23));
            Console.ReadLine();

            Bicornis rhino = new Bicornis("Fred");
            rhino.Welcome();
            Console.WriteLine(rhino.Name + " Weighs " + rhino.Weight + " lbs.");
            Console.WriteLine(rhino.Name + " is " + rhino.Height + " feet long.");
            Console.WriteLine("Is it true that " + rhino.Name + " has a tail? " + rhino.Tail.ToString());
            Console.WriteLine(rhino.Name + " has " + rhino.horns + " horns");
            Console.WriteLine(rhino.Move(11));
            Console.WriteLine(rhino.Eat(5));

            Bicornis rhino2 = new Bicornis(3, "Anthony");
            Console.WriteLine(rhino2.Name + " has a cuteness of " + rhino2.CutenessFactor + " out of 10!");

            Beringei Ape = new Beringei("Mike");
            Console.WriteLine(Ape.Welcome());
            Console.WriteLine(Ape.Name + " Weighs " + Ape.Weight + " lbs.");
            Console.WriteLine(Ape.Name + " is " + Ape.Height + " feet long.");
            Console.WriteLine("Is it true that " + Ape.Name + " has a tail? " + Ape.GetType().Name);
            Console.WriteLine(Ape.Name + " has " + Ape.fingers + " fingers on each hand");
            Console.WriteLine(Ape.Move(33));
            Console.WriteLine(Ape.Eat(2));
            Console.WriteLine(Ape.Name + " is a " + typeof(Beringei));
            
            Beringei Ape2 = new Beringei(32);
            Console.WriteLine(Ape2.Name + " has " + Ape2.Teeth + " teeth");

            Console.WriteLine("Enter the name for your Blue Whale: ");
            string bwName = Console.ReadLine();
            Musculus whale = new Musculus(bwName);
            Console.WriteLine(whale.Welcome());
            Console.WriteLine(whale.Name + " Weighs " + whale.Weight + " lbs.");
            Console.WriteLine(whale.Name + " is " + whale.Height + " feet long.");
            Console.WriteLine("Is it true that " + whale.Name + " has a tail? " + whale.Tail.ToString());
            Console.WriteLine(whale.Name + " has " + whale.fins + " fins ");
            Console.WriteLine(whale.Move(444));
            Console.WriteLine(whale.Eat(200));

            Abelii Orangutan = new Abelii("Ethel");
            Console.WriteLine(Orangutan.Name + " is colored " + Orangutan.Color);
            Console.WriteLine(Orangutan.Name + " weighs " + Orangutan.Weight + " lbs. and is " + Orangutan.Height + " feet tall");
            Console.WriteLine(Orangutan.Eat(14) + " " + Orangutan.Move(22));

            Mississippiensis Alligator = new Mississippiensis("Lars");
            Console.WriteLine(Alligator.Name + " is colored " + Alligator);
            Console.WriteLine(Alligator.Name + " is " + Alligator.Weight + " lbs. and is " + Alligator.Height + " feet long");

            
        }
    }
}
