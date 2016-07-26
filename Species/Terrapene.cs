using System;


	namespace Zoolandia.Species
	{

		public class Terrapene : Animal
		{
			public bool Shell;

			public Terrapene(string name) : base(name)
			{
				this.Shell = true;
				this.Feet = 4;
				this.Tail = true;
			}

			public override String Move(int distance)
			{
				return "I meandered " + distance + " feet. Whew!";
			}
	

        }

    
    }