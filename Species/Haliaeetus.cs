using System;

	namespace Zoolandia.Species
	{
		public class Haliaeetus : Animal
		{
			public float Wingspan;

			public Haliaeetus(string name) : base(name)
			{
				this.Wingspan = 7.5F;
				this.Feet = 2;
				this.Tail = true;
			}

			public override String Move(int distance)
			{
				return "I have flown, on average, about " + distance + " miles a day.";
			}
		}
	}
    