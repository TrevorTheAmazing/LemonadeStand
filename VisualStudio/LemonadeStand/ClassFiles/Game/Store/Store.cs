using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.ClassFiles.Game.Store
{
    public static class Store
    {
        //memb vars
        //public Player player;

        //constructor
        //public Store()
        //{

        //}

        //memb meths
        //BuyStuff()
        //increase inventory
        //decrease money with 
        public static void OpenStore()
        {
                //do Store things
                Console.WriteLine("Please buy something.");
                Console.ReadLine();
                Console.WriteLine("0 - Buy lemons.");
                Console.WriteLine("1 - Buy sugar cubes.");
                Console.WriteLine("2 - Buy ice cubes.");
                Console.WriteLine();
                Console.WriteLine("9 - Leave the store.");

                string tempInput = Console.ReadLine();

                bool leaveStore = false;
                switch (tempInput)
                {

                    case ("0"):
                        Console.WriteLine("You bought lemons.");
                        break;
                    case ("1"):
                        Console.WriteLine("You bought sugar cube.");
                        break;
                    case ("2"):
                        Console.WriteLine("You bought ice cube.");
                        break;
                    case ("9"):
                        leaveStore = true;
                        Console.WriteLine("LEAVE STORE");
                        break;
                    default:
                        break;
                }
        }        
    
        public static void CloseStore()
        {

        }
    }
}
