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
        private int customerCount = 100;

        //constructor
        public Day()
        {
            //set the weather for the day
            weather = new Weather();

            //set play time remaining for the day
            timeRemaining = 100.0;
            
            //add 100 customers to the list each day
            customers = BuildDailyCustomerList( customers, customerCount);
            
            //day complete.
            
        }

        //memb meths
        public List<Customer> BuildDailyCustomerList( List<Customer> customersIn, int customerCountIn)
        //public List<Customer> BuildDailyCustomerList()
        {
            //create a new customer and name it            
            //for (int i = 0; i < CustomerListIn.Count; i++)
            for (int i = 0; i < customerCountIn; i++)
            {
                Customer tempCustomer = new Customer();

                //does this work for string concat?
                tempCustomer.name += i;
                customersIn.Add(tempCustomer);
                //use random to make a range for 'will buy'
            }
            return customersIn;
        }
    }
}
