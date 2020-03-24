using Common;
using System.Threading;
using static System.Console;

namespace ObserverPatternDemo
{
    /// <summary>
    /// Initiate the Observable pattern demo
    /// </summary>
    public class InitiateObserverPattern : IInitiatePattern
    {
        /// <summary>
        /// Starting point of observer design pattern demo
        /// </summary>
        public void Initiate()
        {
            // Observable which can be observed
            WeatherStation station = new WeatherStation();

            // Observer who can watch Observable(WeatherStation)
            // Pass weather station reference so that it can fetch data on notify
            SamsungMobile samsungMobile = new SamsungMobile(station);
            station.AddObserver(samsungMobile);

            // Another Observer who can watch Observable(WeatherStation)
            // Pass weather station reference so that it can fetch data on notify
            MotorolaMobile motorolaMobile = new MotorolaMobile(station);
            station.AddObserver(motorolaMobile);

            // Must be getting automatically from some sensors
            station.SetTemperature(22.5);
            Thread.Sleep(2000);
            station.SetTemperature(22.2);
            Thread.Sleep(2000);
            station.SetTemperature(22.9);

            WriteLine("Station is now shutting down for Today");
        }
    }
}
