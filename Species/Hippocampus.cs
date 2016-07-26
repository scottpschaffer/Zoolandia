using System;
	namespace Zoolandia.Species
	{
		public class Hippocampus : Animal
		{
			public Hippocampus (string name) : base(name)
			{
				this.Feet = 0;
				this.Tail = true;
			}

			public override string Move(int distance)
			{
				return "I flittered through the water for " + distance + " meters";
			}
		}


	}
    