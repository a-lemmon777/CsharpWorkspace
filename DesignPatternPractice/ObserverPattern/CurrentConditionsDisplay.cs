namespace ObserverPattern
{
    using System;

    public class CurrentConditionsDisplay : IDisplayElement, IObserver
    {
        private double temperature;
        private double humidity;
        private readonly WeatherData weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update()
        {
            temperature = weatherData.Temperature;
            humidity = weatherData.Humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: {0}F degrees and {1}% humidity", temperature, humidity);
        }
    }
}