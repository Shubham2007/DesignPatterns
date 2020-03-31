using static System.Console;

namespace AbstractFactoryPatternDemo.MainCourse
{
    /// <summary>
    /// A ConcreteProduct
    /// </summary>
    class EggSandwich : ISandwich
    {
        public void GetSandwich()
        {
            WriteLine("Here is Egg Sandwich for Childs");
        }
    }
}
