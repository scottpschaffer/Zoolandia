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
            Console.WriteLine(Joe.Name + " is " + Joe.Color);
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
            Musculus Whale = new Musculus(bwName);
            Console.WriteLine(Whale.Welcome());
            Console.WriteLine(Whale.Name + " Weighs " + Whale.Weight + " lbs.");
            Console.WriteLine(Whale.Name + " is " + Whale.Height + " feet long.");
            Console.WriteLine("Is it true that " + Whale.Name + " has a tail? " + Whale.Tail.ToString());
            Console.WriteLine(Whale.Name + " has " + Whale.fins + " fins ");
            Console.WriteLine(Whale.Move(444));
            Console.WriteLine(Whale.Eat(200));

            Abelii Orangutan = new Abelii("Ethel");
            Console.WriteLine(Orangutan.Name + " is colored " + Orangutan.Color);
            Console.WriteLine(Orangutan.Name + " weighs " + Orangutan.Weight + " lbs. and is " + Orangutan.Height + " feet tall");
            Console.WriteLine(Orangutan.Eat(14) + " " + Orangutan.Move(22));

            Mississippiensis Alligator = new Mississippiensis("Lars");
            Console.WriteLine(Alligator.Name + " is colored " + Alligator);
            Console.WriteLine(Alligator.Name + " is " + Alligator.Weight + " lbs. and is " + Alligator.Height + " feet long");

            Quagga Zebra = new Quagga("Daniel");
            Console.WriteLine(Zebra.Name + " is colored " + Zebra.Color);
            Console.WriteLine(Zebra.Name + " is " + Zebra.Weight + " lbs. and is " + Zebra.Height + " feet long");
            Console.WriteLine(Zebra.Eat(3) + " & " + Zebra.Move(90));

            Tigris Tiger = new Tigris("Tony");
            Console.WriteLine(Tiger.Name + " is colored " + Tiger.Color);
            Console.WriteLine(Tiger.Name + " is " + Tiger.Weight + " lbs. and is " + Tiger.Height + " feet long");
            Console.WriteLine(Tiger.Eat(6) + " & " + Tiger.Move(40));

            Carolina Turtle = new Carolina("Timmy");
            Console.WriteLine(Turtle.Name + " is colored " + Turtle.Color);
            Console.WriteLine(Turtle.Name + " is " + Turtle.Weight + " lbs. and is " + Turtle.Height + " feet long");
            Console.WriteLine(Turtle.Eat(12) + " & " + Turtle.Move(3));

            Tridactylus Sloth = new Tridactylus("Juan");
            Console.WriteLine(Sloth.Name + " is colored " + Sloth.Color);
            Console.WriteLine(Sloth.Name + " is " + Sloth.Weight + " lbs. and is " + Sloth.Height + " feet long");
            Console.WriteLine(Sloth.Eat(4) + " & " + Sloth.Move(7));

            Leucocephalus Eagle = new Leucocephalus("Sam");
            Console.WriteLine(Eagle.Name + " is colored " + Eagle.Color);
            Console.WriteLine(Eagle.Name + " is " + Eagle.Weight + " lbs. and is " + Eagle.Height + " feet long");
            Console.WriteLine(Eagle.Eat(3) + " & " + Eagle.Move(90));

            Auratus Goldfish = new Auratus("Nemo");
            Console.WriteLine(Goldfish.Name + " is colored " + Goldfish.Color);
            Console.WriteLine(Goldfish.Name + " is " + Goldfish.Weight + " lbs. and is " + Goldfish.Height + " feet long");
            Console.WriteLine(Goldfish.Eat(3) + " & " + Goldfish.Move(90));

            Guttulatus SeaHorse = new Guttulatus("Alan");
            Console.WriteLine(SeaHorse.Name + " is colored " + SeaHorse.Color);
            Console.WriteLine(SeaHorse.Name + " is " + SeaHorse.Weight + " lbs. and is " + SeaHorse.Height + " feet long");
            Console.WriteLine(SeaHorse.Eat(3) + " & " + SeaHorse.Move(90));

            Lupus Wolf = new Lupus("Fritz");
            Console.WriteLine(Wolf.Name + " is colored " + Wolf.Color);
            Console.WriteLine(Wolf.Name + " is " + Wolf.Weight + " lbs. and is " + Wolf.Height + " feet long");
            Console.WriteLine(Wolf.Eat(3) + " & " + Wolf.Move(90));

            Occitanus Scorpion = new Occitanus("Leonard");
            Console.WriteLine(Scorpion.Name + " is colored " + Scorpion.Color);
            Console.WriteLine(Scorpion.Name + " is " + Scorpion.Weight + " grams. and is " + Scorpion.Height + " cm long");
            Console.WriteLine(Scorpion.Eat(3) + " & " + Scorpion.Move(90));

            Aquarium SeaWorld = new Aquarium();
            SeaWorld.AddA(SeaHorse);
            SeaWorld.AddA(Goldfish);
            SeaWorld.AddA(Whale);
            Console.WriteLine("Welcome to " + nameof(SeaWorld));
            Console.WriteLine(SeaWorld.Feeding());
            Console.WriteLine(SeaWorld.Performance());

            Plains Veldtarama = new Plains();
            Veldtarama.AddA(Zebra);
            Veldtarama.AddA(Scorpion);
            Console.WriteLine("Welcome to " + nameof(Veldtarama));
            Console.WriteLine(Veldtarama.Feeding());
            Console.WriteLine(Veldtarama.Performance());

            Aviary BirdTown = new Aviary();
            BirdTown.AddA(Eagle);
            Console.WriteLine("Welcome to " + nameof(BirdTown));
            Console.WriteLine(BirdTown.Feeding());
            Console.WriteLine(BirdTown.Performance());

            Jungle Jungleville = new Jungle();
            Jungleville.AddA(rhino);
            Jungleville.AddA(Ape);
            Jungleville.AddA(Tiger);
            Jungleville.AddA(Orangutan);
            Jungleville.AddA(Alligator);
            Console.WriteLine("Welcome to " + nameof(Jungleville));
            Console.WriteLine(Jungleville.Feeding());
            Console.WriteLine(Jungleville.Performance());

            Jungle Forestland = new Jungle();
            Forestland.AddA(redPanda);
            Forestland.AddA(Turtle);
            Forestland.AddA(Sloth);
            Forestland.AddA(Wolf);
            Console.WriteLine("Welcome to " + nameof(Forestland));
            Console.WriteLine(Forestland.Feeding());
            Console.WriteLine(Forestland.Performance());

        }
    }
}
