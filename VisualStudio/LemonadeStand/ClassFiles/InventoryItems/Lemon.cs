﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LemonadeStand.ClassFiles.Items
{
    public class Lemon : Item
    {
        //memb vars FOR LEMONS    
        public double itemPrice;

        //constructor FOR LEMON
        public Lemon()
        {
            this.name = "Lemon";
            this.quantity = 0;

            this.itemPrice = 0.38;
        }

        //memb meth FOR LEMONS
        //
    }   
}
