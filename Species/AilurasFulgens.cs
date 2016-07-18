using System;

    namespace Zoolandia.Species
    {

        public class AilurusFulgens : Animal
        {
            public string Color = "red"; 
            public AilurusFulgens(string name) : base(name)
            {
                this.Tail = true;
                Random r = new Random();
                this.Weight = r.Next(8, 14);
                this.Height = (float)(r.Next(15, 19));
                this.Feet = 4;
            }
            public override string Eat(int numberOfFoodZ)
            {
                string animalEat = base.Eat(3);
                return animalEat +  " Nom nom nom";
            }

            public override string Move(int distance)
            {
                return this.Name + " has walked " + distance.ToString() + " miles.";
            }

            public string Eat(){
                return "I don't know what I just ate, but it was good";
            }

            public string Welcome(string name)
            {
                this.Name = name;
                return Welcome();
            }

            public string Welcome()
            {
                return "Welcome " + this.Name;
            }
        }   
    }