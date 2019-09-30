using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.ClassFiles.Game.Day
{
    class Day
    {
        //memb vars
        public Weather weather;
        public List<Customer> customers = new List<Customer>();
        public double timeRemaining;

        public Day()
        {
            weather = new Weather();
            //timeRemaining = 24 hours; etc...
        }

        //memb meths
    }
}
