using System;

	namespace Zoolandia.Species
	{

		public class Bradypus : Animal

        	{
			public Bradypus(string name) : base(name)
			{
				this.Tail = false;
				this.Feet = 4;
			}

			public override String Move(int distance)
			{
				return "I ran for " + distance + " meters.";
			}
	

        }


	}