using System;


	namespace Zoolandia.Species
	{

		public class Panthera : Animal

		{


			public int Teeth;

			public Panthera(string name) : base(name)
			{
				this.Teeth = 30;
				this.Feet = 4;
				this.Tail = true;
			}

			public override string Move(int distance)
			{
				return "I stalked prey for " + distance + " miles.";
			}
		}
	}