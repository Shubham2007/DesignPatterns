namespace ObserverPatternDemo
{
    /// <summary>
    /// Observed by IObservers
    /// </summary>
    internal interface IObservable
    {
        /// <summary>
        /// Adds a Observer
        /// </summary>
        /// <param name="observer"></param>
        void AddObserver(IObserver observer);

        /// <summary>
        /// Removes a Observer
        /// </summary>
        /// <param name="observer"></param>
        void RemoveObserver(IObserver observer);

        /// <summary>
        /// Called automatically(leave it how) and notifies each Observers that it has been changed
        /// </summary>
        void Notify();
    }
}
