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
        public List<Customer> customers;// = new List<Customer>();        
        public double timeRemaining;
        private int customerCount = 100;
        //Random random = new Random();

        //constructor
        public Day(Random randomIn)
        {
            //set the weather for the day
            weather = new Weather();

            //set play time remaining for the day
            //timeRemaining = 100.0;

            customers = new List<Customer>();
            //random = new Random();

            //add 100 customers to the list each day
            customers = BuildDailyCustomerList( customers, customerCount, randomIn);
            
            //day complete.
            
        }

        //memb meths
        public List<Customer> BuildDailyCustomerList( List<Customer> customersIn, int customerCountIn, Random randomIn)
        {
            //create a new customer and name it            
            //for (int i = 0; i < CustomerListIn.Count; i++)
            for (int i = 0; i < customerCountIn; i++)
            {
                Customer tempCustomer = new Customer(randomIn);
                //Random random = new Random();

                tempCustomer.name += i;
                //tempCustomer.willPurchase = ((random.Next(0, 101)) >= 50);
                //tempCustomer.maxPurchasePrice = ((random.NextDouble() * (6.0 - 1.0)) + 1.0);
                //tempCustomer.internalResistance = random.Next(0, 101);
                customersIn.Add(tempCustomer);                
            }
            
            return customersIn;
        }
    }
}
