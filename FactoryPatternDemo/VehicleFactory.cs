namespace FactoryPatternDemo
{
    /// <summary>
    /// The Creator Abstract Class
    /// </summary>
    internal abstract class VehicleFactory
    {
        /// <summary>
        /// Return the shipping vehicle
        /// </summary>
        /// <param name="deliveryHours"></param>
        /// <returns></returns>
        internal abstract IShippingVehicle GetShippingVehicle(DeliverySpeedEnum deliverySpeed);
    }
}
