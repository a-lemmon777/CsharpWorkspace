namespace ObserverPattern
{
    using System.Collections.Generic;

    public class WeatherData : ISubject
    {
        private readonly List<IObserver> observers = new List<IObserver>();
        private double temperature;
        private double humidity;
        private double pressure;

        public void RegisterObserver(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in this.observers)
            {
                observer.Update(this.temperature, this.humidity, this.pressure);
            }
        }

        private void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(double temperature, double humidity, double pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
    }
}