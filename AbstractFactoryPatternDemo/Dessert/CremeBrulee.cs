using static System.Console;

namespace AbstractFactoryPatternDemo.Dessert
{
    /// <summary>
    /// A ConcreteProduct
    /// </summary>
    class CremeBrulee : IDessert
    {
        public void GetDessert()
        {
            WriteLine("Here is Creme Brulee for adults");
        }
    }
}
