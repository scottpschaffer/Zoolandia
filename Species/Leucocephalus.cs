using System;
	namespace Zoolandia.Species
	{
		public class Leucocephalus : Haliaeetus

		{


			public string Color;
			public string commonName = "Bald Eagle";

			public Leucocephalus(string name) : base(name)
			{
				this.Color = "brown";
				this.Weight = 14;
				this.Height = 79.7F;
			}

			public override string Eat(int numFood)
			{
				return "I eat about " + numFood + " critters a day.";
			}
		}


	}