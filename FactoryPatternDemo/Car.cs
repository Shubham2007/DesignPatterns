using static System.Console;

namespace FactoryPatternDemo
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    internal class Car : IShippingVehicle
    {
        /// <summary>
        /// Ship product using car
        /// </summary>
        /// <param name="productName"></param>
        public void ShipProduct(string productName)
        {
            WriteLine($"Shipping {productName} using Car");
        }
    }
}
