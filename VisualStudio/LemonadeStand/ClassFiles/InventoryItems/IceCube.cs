﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LemonadeStand.ClassFiles.Items
{
    public class IceCube : Item
    {
        //memb vars FOR IceCube   
        //public int Quantity;
        public double itemPrice;

        //constructor FOR ICECUBE
        //public IceCube(string Name, double Price)
        public IceCube()
        {
            this.name = "IceCube";
            this.quantity = 0;
            this.itemPrice = 1.00;

            //defaults
            //color = "air"
        }

        //memb meth FOR ICECUBE
    }
}
