namespace ObserverPatternDemo
{
    /// <summary>
    /// Used to observe a IObservable
    /// </summary>
    internal interface IObserver
    {
        /// <summary>
        /// Called from concrete Observable on change of its state
        /// </summary>
        void Update();
    }
}
