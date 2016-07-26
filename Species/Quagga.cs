using System;
	namespace Zoolandia.Species
	{
		public class Quagga : Equus
		{


			public string Color;

			public Quagga(string name) : base(name)
			{
				this.Color = "White with black stripes";
				this.Weight = 190;
				this.Height = 6.75F;
			}

			public override string Eat(int numFood)
			{
				return "I eat about " + numFood + "blades of grass per hour";
			} 
		}

	}