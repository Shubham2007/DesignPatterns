namespace FactoryPatternDemo
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    internal class ConcreteVehicleFactory : VehicleFactory
    {
        /// <summary>
        /// Return the concrete shipping vehicle
        /// </summary>
        /// <param name="deliveryHours"></param>
        /// <returns></returns>
        internal override IShippingVehicle GetShippingVehicle(DeliverySpeedEnum deliverySpeed)
        {
            switch (deliverySpeed)
            {
                case DeliverySpeedEnum.Fast:
                    return new Car();

                case DeliverySpeedEnum.Normal:
                    return new Bike();

                default:
                    return null;
            }
        }
    }
}
