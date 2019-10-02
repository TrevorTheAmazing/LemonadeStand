using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.ClassFiles.Game.Day
{
    public class Weather
    {
        //memb vars
        public string condition;
        public int temperature;
        public string predictedForecast;
        private List<string> weatherConditions = new List<string>() { "It's a scorcher wow such heat", "Sunny and hot", "Exceptionally nice and borderline perfect", "Cloudy but warm", "No rain but pretty chill", "Cold and rainy" };

        //constru
        public Weather()
        {
            Random random = new Random();
            int tempRando = random.Next(0, weatherConditions.Count);
            //this.condition = weatherConditions[random.Next(0, weatherConditions.Count)];
            this.condition = weatherConditions[tempRando];

            //put logic here to set the random range based on the conditions
            switch (tempRando)
            {
                case (0):
                    this.temperature = random.Next(98, 106);
                    break;
                case (1):
                    this.temperature = random.Next(81, 99);
                    break;
                case (2):
                    this.temperature = random.Next(72, 82);
                    break;
                case (3):
                    this.temperature = random.Next(63, 73);
                    break;
                case (4):
                    this.temperature = random.Next(54, 65);
                    break;
                case (5):
                    this.temperature = random.Next(48, 55);                    
                    break;
                default:
                    this.temperature = 68;
                    break;
            }                       

            try
            {
                this.predictedForecast = weatherConditions[tempRando + 1];
            }            
            catch(ArgumentOutOfRangeException)
            {
                this.predictedForecast = weatherConditions[0];
            }

        }

        //memb meths
        public string WeatherReport()
        {
            return ("Today's weather: " + condition + ", " + (temperature.ToString() + " degrees."));
        }    
        
        public string WeatherPrediction()
        {
            return predictedForecast;
        }
    }
}
