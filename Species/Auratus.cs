using System;

	namespace Zoolandia.Species
	{

        	public class Auratus : Carassius

		{
			public String Color;

			public Auratus (string name) : base(name)
			{
				this.Color = "gold";
				this.Weight = 1;
				this.Height = 0.2F;
			}

			public override String Eat(int numFood)
			{
				return "I eat " + numFood + " plankton  a day.";
			}
	

        }

	}