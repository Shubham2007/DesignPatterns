using static System.Console;

namespace AbstractFactoryPatternDemo.MainCourse
{
    /// <summary>
    /// A ConcreteProduct
    /// </summary>
    class LambSandwich : ISandwich
    {
        public void GetSandwich()
        {
            WriteLine("Here is Lamb Sandwich for adults");
        }
    }
}
