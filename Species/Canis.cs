using System;

	namespace Zoolandia.Species
	{
		public class Canis : Animal
		{
			public int Teeth;

			public Canis(string name) : base(name)
			{
				this.Teeth = 42;
				this.Feet = 4;
				this.Tail = true;
			}

			public override String Move(int distance)
			{
				return "I loped " + distance + " miles through the forest.";
			}
		}



	}