using AbstractFactoryPatternDemo;
using Common;
using FactoryPatternDemo;
using ObserverPatternDemo;
using StrategyPatternDemo;
using System;
using static System.Console;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxPatternsAvailable = 4;

            PrintPatterns();

            string userInput = ReadLine();

            // Validate input
            if (!int.TryParse(userInput, out int patternChoice))
            {
                throw new Exception("Please enter interger only");
            }
            else if(patternChoice < 1 || patternChoice > maxPatternsAvailable)
            {
                throw new Exception("Please enter a valid pattern number");
            }

            IInitiatePattern pattern = GetPatternInstance(patternChoice);

            if (pattern == null)
                throw new ArgumentNullException(nameof(pattern));

            // Call the actual pattern
            pattern.Initiate();

            ReadKey();
        }

        /// <summary>
        /// Returns the actual pattern instance
        /// </summary>
        /// <param name="patternChoice"></param>
        /// <returns></returns>
        private static IInitiatePattern GetPatternInstance(int patternChoice)
        {
            switch (patternChoice)
            {
                // Observer pattern
                case 1:
                    return new InitiateObserverPattern();

                case 2:
                    return new InitiateStrategyPattern();

                case 3:
                    return new InitiateFactoryPattern();

                case 4:
                    return new InitiateAbstractFactoryPattern();

                default:
                    return null;
            }
        }

        /// <summary>
        /// Print the list of available patterns
        /// </summary>
        private static void PrintPatterns()
        {
            WriteLine("1 - Observer Pattern");
            WriteLine("2 - Strategy Pattern");
            WriteLine("3 - Factory Pattern");
            WriteLine("4 - Abstract Factory Pattern");
            WriteLine("Enter your choice");
            WriteLine();
        }
    }
}
