using System;

namespace ObserverPattern
{
    public class StatisticsDisplay : IDisplayElement, IObserver
    {
        private double maxTemp = 0;
        private double minTemp = 200;
        private double tempSum = 0;
        private int numReadings = 0;
        private readonly WeatherData weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update()
        {
            tempSum += weatherData.Temperature;
            numReadings++;

            if (weatherData.Temperature > maxTemp)
            {
                maxTemp = weatherData.Temperature;
            }

            if (weatherData.Temperature < minTemp)
            {
                minTemp = weatherData.Temperature;
            }

            Display();
        }

        public void Display()
        {
            Console.WriteLine("Avg/Max/Min temperature = {0}/{1}/{2}", tempSum / numReadings, maxTemp, minTemp);
        }
    }
}