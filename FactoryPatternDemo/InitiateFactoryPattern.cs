using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using static System.Console;

namespace FactoryPatternDemo
{
    /// <summary>
    /// Initiate the factory pattern demo
    /// </summary>
    public class InitiateFactoryPattern : IInitiatePattern
    {
        // <summary>
        /// Starting point of factory design pattern demo
        /// </summary>
        public void Initiate()
        {
            Dictionary<string, int> products = new Dictionary<string, int>();
            string repeat = string.Empty;

            do
            {
                WriteLine("Enter prduct name to add in shopping cart");
                string productName = ReadLine();

                WriteLine("Choose the delievry speed");
                WriteLine("1 - Fast");
                WriteLine("2 - Normal");

                string choice = ReadLine();

                if (!int.TryParse(choice, out int deliverySpeed))
                {
                    throw new ArgumentException("Please enter integer only");
                }
                else if(deliverySpeed > 2 || deliverySpeed < 1)
                {
                    throw new ArgumentOutOfRangeException("Please enter the correct delivery method");
                }

                products.Add(productName, deliverySpeed);

                WriteLine("Want to add more products (Y|N)");
                repeat = ReadLine(); 

            } while (repeat.Equals("y", StringComparison.OrdinalIgnoreCase));

            if (products == null || !products.Any())
            {
                WriteLine("No product is added in cart to ship");
                return;
            }
                
            VehicleFactory vehicleFactory = new ConcreteVehicleFactory();

            foreach(KeyValuePair<string, int> product in products)
            {
                IShippingVehicle shippingVehicle = vehicleFactory.GetShippingVehicle((DeliverySpeedEnum)product.Value);
                shippingVehicle.ShipProduct(product.Key);
                Thread.Sleep(2000);
            }

            WriteLine("\nAll products are shipped successfully");

            ReadKey();
        }
    }
}
