using System;

	namespace Zoolandia.Species
	{

        	public class Auratus : Carassius

		{
			public String Color;

			public Auratus (string name) : base(name)
			{
				this.Color = "gold";
				this.weight = 1;
				this.height = 0.2F;
			}

			public override String Eat(int numFood)
			{
				return "I eat " + numFood + " plankton  a day.";
			}
	

        }

	}