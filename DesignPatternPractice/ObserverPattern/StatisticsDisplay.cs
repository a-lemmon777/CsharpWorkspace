using System;

namespace ObserverPattern
{
    public class StatisticsDisplay : IDisplayElement, IObserver
    {
        private double maxTemp = 0;
        private double minTemp = 200;
        private double tempSum = 0;
        private int numReadings = 0;
        private ISubject weatherData;

        public StatisticsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(double temperature, double humidity, double pressure)
        {
            this.tempSum += temperature;
            this.numReadings++;

            if (temperature > this.maxTemp)
            {
                this.maxTemp = temperature;
            }

            if (temperature < this.minTemp)
            {
                this.minTemp = temperature;
            }

            Display();
        }

        public void Display()
        {
            Console.WriteLine("Avg/Max/Min temperature = {0}/{1}/{2}", this.tempSum / this.numReadings, this.maxTemp, this.minTemp);
        }
    }
}