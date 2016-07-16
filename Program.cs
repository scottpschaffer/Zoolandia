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


            Console.ReadLine();

        }
    }
}
