using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LemonadeStand.ClassFiles.Items
{
    public class SugarCube : Item
    {
        //memb vars FOR SugarCube    
        //public int Quantity;
        public double itemPrice;

        //constructor FOR SugarCube
        //public SugarCube(string Name, double Price)
        public SugarCube()
        {
            this.name = "SugarCube";
            this.quantity = 0;
            this.itemPrice = 1.00;

            //defaults
            //color = "white"
        }

        //memb meth FOR SugarCube
    }
}
