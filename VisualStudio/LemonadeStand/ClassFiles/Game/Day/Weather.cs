using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.ClassFiles.Game.Day
{
    class Weather
    {
        //memb vars
        public string condition;
        public int temperature;
        public string predictedForecast;
        private List<string> weatherConditions = new List<string>() { "Sunny and hot.", "Cloudy, but warm.", "Cold and rainy." };

        //constru
        public Weather()
        {
            Random random = new Random();
            this.condition = weatherConditions[random.Next(0, weatherConditions.Count)];
            this.temperature = random.Next(81, 102);
            this.predictedForecast = "'Nice.' - courtesy of the Weather Underground";
        }

        //memb meths
        //GetForecast()
        //CurrentConditions()
        //PredictForecast()

    }
}
