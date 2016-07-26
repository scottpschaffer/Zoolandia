using System;


    namespace Zoolandia.Species

    {
        
	public class Carassius : Animal

        {

		public Carassius(string name) : base(name)
		{

			this.Feet = 0;
			this.Tail = true;
		}

		public override String Move(int distance)
		{
			return "I swam " + distance + " miles non-stop!";
		}
	}



    }