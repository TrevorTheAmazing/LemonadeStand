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
        private List<string> names = new List<string>();
        public string name;

        //constructor
        public Customer()
        {
            this.name = "Customer";
            //call "AddCustomerToList(CustomerName)" add the customer to the list? - no; doing it in Day().
            this.names = BuildNewCustomerList();
        }

        //memb meths
        //AddCustomerToList(CustomerNameIn) - no; doing it in Day().
        public List<string> BuildNewCustomerList()
        {
            for (int i = 0; i < 100; i++)
            {
                Customer tempCustomer = new Customer();
                tempCustomer.name = tempCustomer.name + i;

                names.Add(tempCustomer.name);
            }

            return names;
        }

}
}
