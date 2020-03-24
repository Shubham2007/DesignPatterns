using static System.Console;

namespace ObserverPatternDemo
{
    /// <summary>
    /// Observer which wants to display temperature whenever changes
    /// </summary>
    internal class MotorolaMobile : IObserver, IDisplay
    {
        private WeatherStation _weatherStation;

        /// <summary>
        /// Instance of Observable to fetch data on Update
        /// </summary>
        /// <param name="weatherStation"></param>
        internal MotorolaMobile(WeatherStation weatherStation)
        {
            _weatherStation = weatherStation;
        }

        /// <summary>
        /// Called by Observable on change event
        /// </summary>
        public void Update()
        {
            // Simply display the temp on Update(Notify from Observable)
            Display();
        }

        /// <summary>
        /// Display the changed temperature
        /// </summary>
        public void Display()
        {
            double changedTemperature = _weatherStation.GetTemperature();
            WriteLine($"MotorolaMobile Detected Temperature Change. Current Temperature is: {changedTemperature}");
        }
    }
}
