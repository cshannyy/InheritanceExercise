using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal--DONE
            // give this class 4 members that all Animals have in common--DONE


            // Create a class Bird--DONE
            // give this class 4 members that are specific to Bird--DONE
            // Set this class to inherit from your Animal Class--DONE

            // Create a class Reptile--DONE
            // give this class 4 members that are specific to Reptile--DONE
            // Set this class to inherit from your Animal Class--DONE




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             * 
             * Creatively display the class member values 
             */

            var myBird = new Bird();
            myBird.Feathers = "Purple";
            myBird.Wings = "Strong";
            myBird.BeakLength = 3;
            myBird.AreTalons = true;







            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var Aligator = new Reptile();
            Aligator.Habitat = "Swampy";
            Aligator.Scales = "Green";
            Aligator.Weight = 987;
            Aligator.Eggs = "Large";

            var myAnimals = new Animal[] { myBird, Aligator };

            foreach(var animal in myAnimals)
            {



                Console.WriteLine($"Fur is {animal.FurColor}");
                Console.WriteLine($"It has paws: {animal.Paws}");
                Console.WriteLine($"It has whiskers: {animal.AreWhiskers}");
                Console.WriteLine($"Tail:{animal.Tail}");
                Console.WriteLine($"");
                

            }

        }
    }
}
