using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes
            
            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var myBird = new Bird();
            myBird.Name = "Charlie";
            myBird.Age = 1;
            myBird.NumberOfLegs = 2;
            myBird.DeadOrAlive = true;
            myBird.Color = "blue";
            myBird.CanFly = true;
            myBird.Migrate = true;
            myBird.BeakLength = 5.5;

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *
             * Creatively display the class member values
             */

            var snakeOne = new Reptile();
            snakeOne.Name = "George";
            snakeOne.Age = 2;
            snakeOne.NumberOfLegs = 0;
            snakeOne.DeadOrAlive = true;
            snakeOne.IsColdBlooded = true;
            snakeOne.IsScaly = true;
            snakeOne.Habitat = "desert";
            snakeOne.CanGrowTail = true;

            var myAnimals = new List<Animal>() { myBird, snakeOne };

            foreach (var animal in myAnimals)
            {
                Console.WriteLine(
                    $"What is its name: {animal.Name}\nHow old: {animal.Age} years old\nHow many legs: {animal.NumberOfLegs}\nIs it alive: {animal.DeadOrAlive}");
                Console.WriteLine();
            }
        }
    }
}
