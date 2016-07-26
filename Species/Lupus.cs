using System;


	namespace Zoolandia.Species
	{

		public class Lupus : Canis

		{


			public string Color;

			public Lupus(string name) : base(name)
			{
				this.Color = "gray";
				this.Weight = 250;
				this.Height = 5.4F;
			}

			public override String Eat(int numFood)
			{
				return "I eat about " + numFood + " little animals per day";
			}
		}
	}