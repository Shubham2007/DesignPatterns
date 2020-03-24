using static System.Console;

namespace StrategyPatternDemo
{
    /// <summary>
    /// A Concrete Strategy class to cook food
    /// </summary>
    internal class Baking : ICookingStrategy
    {
        public void Cook(string food)
        {
            WriteLine($"Cooking {food} by Baking");
        }
    }
}
