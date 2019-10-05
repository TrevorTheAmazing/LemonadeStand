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
        public List<IceCube> iceCubes;
        public List<Cup> cups;

        //constructor
        public Inventory()
        {
        lemons = new List<Lemon>();
        sugarCubes = new List<SugarCube>();
        iceCubes = new List<IceCube>();
        cups = new List<Cup>();
    }
        //memb meths
        //public string InventoryReport() to give the name of the item and the quantity of the item
        public void InventoryReport()
        {
            //string tempInventory = Environment.NewLine + "You have " + /*inventory.*/lemons.Count + " lemons, " +
            Console.WriteLine( Environment.NewLine + "You have " + /*inventory.*/lemons.Count + " lemons, " +
                /*inventory.*/sugarCubes.Count + " sugar cubes, and " +
                /*inventory.*/iceCubes.Count + " ice cubes." + Environment.NewLine +
                "You also have " + /*inventory.*/cups.Count + " cups." + Environment.NewLine);

            //return tempInventory;
        }
    }
}
