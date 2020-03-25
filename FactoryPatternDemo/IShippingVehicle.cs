namespace FactoryPatternDemo
{
    /// <summary>
    /// The 'Product' interface
    /// </summary>
    internal interface IShippingVehicle
    {
        /// <summary>
        /// Ships the product
        /// </summary>
        /// <param name="productName"></param>
        void ShipProduct(string productName);
    }
}
