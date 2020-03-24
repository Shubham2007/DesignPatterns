using System;

namespace StrategyPatternDemo
{
    /// <summary>
    /// The Context class, which maintains a reference to the chosen Strategy.
    /// </summary>
    internal class CookingMethod
    {
        internal static ICookingStrategy GetCookingStartegy(int cookingChoice)
        {
            if (cookingChoice < 1 && cookingChoice > 2)
                throw new ArgumentOutOfRangeException("Please enter the correct cooking method");

            switch (cookingChoice)
            {
                case 1:
                    return new Grilling();

                case 2:
                    return new Baking();

                default:
                    return null;
            }
        }
    }
}
