using System;
	namespace Zoolandia.Species
	{
		public class Leucocephalus : Haliaeetus

		{


			public string Color;

			public Leucocephalus(string name) : base(name)
			{
				this.Color = "brown";
				this.Weight = 14;
				this.Height = 79.7;
			}

			public override string Eat(int numFood)
			{
				return "I eat about " + numFood + " critters a day.";
			}
		}


	}