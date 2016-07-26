using System;


	namespace Zoolandia.Species

	{
		public class Tigris : Panthera
		{
			public string Color;

			public Tigris(string name) : base(name)
			{
				this.Color = "orange with black and white stripes";
				this.Weight = 310;
				this.Height = 6.2;
			}

			public override string Eat(int numFood)
			{
				return "I feasted on the flesh of " + numFood + " victims today.";
			}
		}
	}