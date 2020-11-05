using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            Console.WriteLine("Bird: 1");
            FurColor = "White";
            Paws = false;
            AreWhiskers = false;
            Tail = "Not fluffy";
        }

        public string Feathers { get; set; }
        public string Wings { get; set; }
        public double BeakLength { get; set; }
        public bool AreTalons { get; set; }
    }
}
