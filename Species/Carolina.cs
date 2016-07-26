using System;

	namespace Zoolandia.Species
	{

		public class Carolina : Terrapene
		{


			public String Color;

			public Carolina(string name) : base(name)
			{
				this.Color = "brown";
				this.Weight = 10;
				this.Height = 2.5;
			}

			public override String Eat(int numFood)
			{
				return " I eat " + numFood + " leaves per day";
			}
	        }
    
    }