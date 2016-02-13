using System;

namespace ObserverPattern
{
    public class ForecastDisplay : IDisplayElement, IObserver
    {
        private double currentPressure = 29.92;
        private double lastPressure;
        private WeatherData weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(double temperature, double humidity, double pressure)
        {
            this.lastPressure = this.currentPressure;
            this.currentPressure = pressure;
            Display();
        }

        public void Display()
        {
            string forecast;
            if (this.currentPressure > this.lastPressure)
            {
                forecast = "Improving weather on the way!";
            }
            else if (this.currentPressure < this.lastPressure)
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