using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.ClassFiles.Game.Day
{
    class Customer
    {        
        //memb vars
        //private List<string> names = new List<string>();
        public string name;

        //constructor
        public Customer()
        {
            this.name = "Customer";
            //create a boolean membvar "willPurchase", init to false
            
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
