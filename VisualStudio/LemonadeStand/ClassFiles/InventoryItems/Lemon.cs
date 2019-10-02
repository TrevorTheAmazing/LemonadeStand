using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LemonadeStand.ClassFiles.Items
{
    public class Lemon : Item
    {
        //memb vars FOR LEMONS    
        //public int Quantity;
        public double itemPrice;

        //constructor FOR LEMON
        //public Lemon(string Name, double Price)
        public Lemon()
        {
            this.name = "Lemon";
            this.quantity = 0;
            this.itemPrice = 1.00;

            //defaults
            //color = "yellow"
        }

        //memb meth FOR LEMONS
        //
    }   
}
