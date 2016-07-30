using System;

	namespace Zoolandia.Species

	{
		public class Tridactylus : Bradypus
		{


			public string Color;
			public int Toes;
			public string commonName = "Three-Toed Sloth";

			public Tridactylus (string name) : base(name)
			{
				this.Color = "gray";
				this.Toes = 12;
				this.Weight = 140;
				this.Height = 4.3F;
			}

			public override String Eat(int numFood)
			{
				return "I am on a strict diet of " + numFood + " blades of grass";
			}
		}
	}