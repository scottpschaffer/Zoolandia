using System;
	namespace Zoolandia.Species
	{
		public class Equus : Animal

        {
			public int Teeth;

			public Equus(string name) : base(name)
			{
				this.Teeth = 40;
				this.Feet = 4;
				this.Tail = true;
			}

			public override String Move(int distance)
			{
			return "I trotted " + distance + " miles!";
    		}
    	}
	}



