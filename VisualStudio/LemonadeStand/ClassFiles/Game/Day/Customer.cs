using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LemonadeStand.ClassFiles.PlayerItems;

namespace LemonadeStand.ClassFiles.Game.Day
{
    class Customer
    {        
        //memb vars
        //private List<string> names = new List<string>();
        public string name;
        public bool willPurchase;
        public int internalResistance;
        public double maxPurchasePrice;
        public Recipe customerPreferences;
        //Random random = new Random();

        //constructor
        public Customer(Random randomIn)
        {
            
            this.name = "Customer";
            this.willPurchase = ((randomIn.Next(0, 101)) >= 50);
            this.maxPurchasePrice = ((randomIn.NextDouble() * (6.0 - 1.0)) + 1.0);
            this.internalResistance = randomIn.Next(0, 101);

            this.customerPreferences = new Recipe();
            customerPreferences.amountOfLemons = randomIn.Next(0, 3);
            customerPreferences.amountOfSugarCubes = randomIn.Next(0, 3);
            customerPreferences.amountOfIceCubes = randomIn.Next(0, 3);
            customerPreferences.pricePerCup = 0.0;
        }

        

        //memb meths
        //private List<string> BuildNewCustomerNamesList(List<string> CustomerNamesListIn)
        //{
        //    Random random = new Random();
        //    for (int i = 0; i < 100; i++)
        //    {
        //        CustomerNamesListIn.Add(this.name + random.Next(1, 1001));
        //    }

        //    return CustomerNamesListIn;
        //}
    }
}
