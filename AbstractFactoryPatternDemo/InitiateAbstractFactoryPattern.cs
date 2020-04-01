using AbstractFactoryPatternDemo.Recipes;
using Common;
using System;
using System.Threading;
using static System.Console;

namespace AbstractFactoryPatternDemo
{
    public class InitiateAbstractFactoryPattern : IInitiatePattern
    {
        public void Initiate()
        {
            WriteLine("Who are you?\nAdult = A\nChild = C");
            string input = ReadLine();

            // Validate input
            if(string.IsNullOrEmpty(input) && (input.ToLower() != "a" || input.ToLower() != "c"))
            {
                throw new ArgumentOutOfRangeException("Please enter valid choice");
            }

            RecipeFactory factory;

            // Choose factory to get releated objects
            switch (input.ToLower())
            {
                case "a":
                    factory = new AdultCuisineFactory();
                    break;

                case "c":
                    factory = new ChildCuisineFactory();
                    break;

                default:
                    throw new NotImplementedException();
            }

            WriteLine("Please wait while we are creating your sandwich and dessert");
            Thread.Sleep(2000);

            // Factory will generate related objects
            var sandwich = factory.CreateSandwich();
            var dessert = factory.CreateDessert();

            WriteLine("\nSandwich: " + sandwich.GetType().Name);
            WriteLine("Dessert: " + dessert.GetType().Name);
        }
    }
}
