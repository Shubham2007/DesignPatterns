using System.Collections.Generic;

namespace ObserverPatternDemo
{
    internal class WeatherStation : IObservable
    {
        /// <summary>
        /// List of Observers observing the Observable
        /// </summary>
        private List<IObserver> _observers;

        private double _currentTemperature = 22.7;

        internal WeatherStation()
        {
            _observers = new List<IObserver>();
        }

        /// <summary>
        /// Add the Observer
        /// </summary>
        /// <param name="observer"></param>
        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        /// <summary>
        /// Remove the Observer
        /// </summary>
        /// <param name="observer"></param>
        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        /// <summary>
        /// Change event of Observable, happens automatically on certain events
        /// </summary>
        public void Notify()
        {
            foreach(IObserver observer in _observers)
            {
                // Update each Observer
                observer.Update();
            }
        }    
        
        /// <summary>
        /// Recieved from satellites or sensors or anything which Observers wants to know when changed
        /// </summary>
        /// <param name="temp"></param>
        /// <returns></returns>
        public void SetTemperature(double temp)
        {
            _currentTemperature = temp;
            Notify();
        }

        /// <summary>
        /// Observer will call this when they will be notified
        /// </summary>
        /// <returns></returns>
        public double GetTemperature()
            => _currentTemperature;
    }
}
