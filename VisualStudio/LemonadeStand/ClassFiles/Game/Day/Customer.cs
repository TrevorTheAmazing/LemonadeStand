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
        public int purchasePower;
        public double maxPurchasePrice;
        public Recipe customerPreferences;

        //constructor
        public Customer()
        {
            this.name = "Customer";
            this.willPurchase = false;
            this.maxPurchasePrice = 0.0;
            this.purchasePower = 0;
            
            customerPreferences = new Recipe();
            customerPreferences.amountOfLemons = 1;
            customerPreferences.amountOfSugarCubes = 1;
            customerPreferences.amountOfIceCubes = 1;       
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
