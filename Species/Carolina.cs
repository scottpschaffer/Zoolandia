using System;

	namespace Zoolandia.Species
	{

		public class Carolina : Terrapene
		{


			public String Color;
			public string commonName = "Box Turtle";

			public Carolina(string name) : base(name)
			{
				this.Color = "brown";
				this.Weight = 10;
				this.Height = 2.5F;
			}

			public override String Eat(int numFood)
			{
				return " I eat " + numFood + " leaves per day";
			}
	        }
    
    }