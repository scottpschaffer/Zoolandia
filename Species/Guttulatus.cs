using System;


	namespace Zoolandia.Species

	{
		public class Guttulatus : Hippocampus
		{
			public string Color;

			public Guttulatus(string name) : base(name)
			{
				this.Color = "tan";
				this.Weight = 1;
				this.height = 1.5F;
			}

			public override string Eat(int numFood)
			{
				return "I eat " + numFood + " ounces of Plankton a day";
			}
		}

	}