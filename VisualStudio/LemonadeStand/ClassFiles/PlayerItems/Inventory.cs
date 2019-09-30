using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LemonadeStand.ClassFiles.Items;

namespace LemonadeStand.ClassFiles.PlayerItems
{
    public class Inventory
    {
        //memb vars
        public List<Lemon> lemons;
        public List<SugarCube> sugarCubes;
        public List<IceCube> iceCube;
        public List<Cup> cup;

        //constructor
        public Inventory()
        {
        lemons = new List<Lemon>();
        sugarCubes = new List<SugarCube>();
        iceCube = new List<IceCube>();
        cup = new List<Cup>();
    }
        //memb meths
        //Report() to give the name of the item and the quantity of the item
    }
}
