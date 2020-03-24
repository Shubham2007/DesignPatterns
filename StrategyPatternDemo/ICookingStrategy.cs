namespace StrategyPatternDemo
{
    /// <summary>
    /// The Strategy interface common to all supported strategy algorithms.
    /// </summary>
    internal interface ICookingStrategy
    {
        void Cook(string food);
    }
}
