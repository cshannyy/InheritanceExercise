using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {

            Console.WriteLine("Aligator: 2");


            FurColor = "not a part of reptiles";
            Paws = false;
            AreWhiskers = false;
            Tail = "They use there tails for differnt things";

        }

        public string Habitat { get; set; }
        public string Scales { get; set; }
        public double Weight { get; set; }
        public string Eggs { get; set; }
    }
}
