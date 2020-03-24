using System;
using System.Threading;
using Common;
using static System.Console;

namespace StrategyPatternDemo
{
    /// <summary>
    /// Initiate the Strategy pattern demo
    /// </summary>
    public class InitiateStrategyPattern : IInitiatePattern
    {
        /// <summary>
        /// Starting point of strategy design pattern demo
        /// </summary>
        public void Initiate()
        {
            WriteLine("What food would you like to cook?");
            string food = ReadLine();

            PrintCookingMethods();

            string choice = ReadLine();
            if(!int.TryParse(choice, out int cookingMethod))
            {
                throw new ArgumentException("Please enter integer only");
            }

            ICookingStrategy cookingStrategy = CookingMethod.GetCookingStartegy(cookingMethod);
            cookingStrategy.Cook(food);

            Thread.Sleep(2000);
            WriteLine("Food has been cooked successfully");
        }

        private void PrintCookingMethods()
        {
            WriteLine("What cooking strategy would you like to use (1-2)?");
            WriteLine("1 - Grilling");
            WriteLine("2 - Baking");
            WriteLine();
        }
    }
}
