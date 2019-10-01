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
            customers = BuildDailyCustomerList(customers);
            
            //day complete.
            
        }

        //memb meths
        public List<Customer> BuildDailyCustomerList(List<Customer> CustomerListIn)
        {
            //create a new customer and name it
            for (int i = 0; i < CustomerListIn.Count; i++)
            {
                Customer tempCustomer = new Customer();

                //does this work for string concat?
                tempCustomer.name += i;
                CustomerListIn.Add(tempCustomer);
            }
            return CustomerListIn;
        }
    }
}
