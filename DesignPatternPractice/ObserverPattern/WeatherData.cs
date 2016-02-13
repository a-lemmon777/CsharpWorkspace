namespace ObserverPattern
{
    using System.Collections.Generic;

    public class WeatherData : ISubject
    {
        private readonly List<IObserver> observers = new List<IObserver>();
        public double Temperature { get; private set; }
        public double Humidity { get; private set; }
        public double Pressure { get; private set; }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update();
            }
        }

        private void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(double temperature, double humidity, double pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            MeasurementsChanged();
        }
    }
}