namespace ObserverPattern
{
    using System;

    public class CurrentConditionsDisplay : IDisplayElement, IObserver
    {
        private double temperature;
        private double humidity;
        private ISubject weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(double temperature, double humidity, double pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: {0}F degrees and {1}% humidity", this.temperature, this.humidity);
        }
    }
}