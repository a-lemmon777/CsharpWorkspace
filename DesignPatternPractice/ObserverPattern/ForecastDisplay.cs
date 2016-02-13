using System;

namespace ObserverPattern
{
    public class ForecastDisplay : IDisplayElement, IObserver
    {
        private double currentPressure = 29.92;
        private double lastPressure;
        private readonly WeatherData weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update()
        {
            lastPressure = currentPressure;
            currentPressure = weatherData.Pressure;
            Display();
        }

        public void Display()
        {
            string forecast;
            if (currentPressure > lastPressure)
            {
                forecast = "Improving weather on the way!";
            }
            else if (currentPressure < lastPressure)
            {
                forecast = "Watch out for cooler, rainy weather.";
            }
            else
            {
                forecast = "More of the same.";
            }
            Console.WriteLine("Forecast: {0}", forecast);
        }
    }
}