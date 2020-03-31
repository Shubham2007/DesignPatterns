using static System.Console;

namespace AbstractFactoryPatternDemo.Dessert
{
    /// <summary>
    /// A ConcreteProduct
    /// </summary>
    class IceCream : IDessert
    {
        public void GetDessert()
        {
            WriteLine("Here is Ice Creme for childs");
        }
    }
}
