using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LemonadeStand.ClassFiles.Game;

namespace LemonadeStand.ClassFiles.Game.Day
{
    class Day
    {
        //memb vars
        public Weather weather;
        public List<Customer> customers = new List<Customer>();
        public double timeRemaining;

        //constructor
        public Day()
        {
            //set the weather for the day
            weather = new Weather();

            //set play time remaining for the day
            timeRemaining = 100.0;
            
            //add 100 customers to the list each day
            customers = Customer.names;
            
            //day complete.
            
        }

        //memb meths
        
    }
}
