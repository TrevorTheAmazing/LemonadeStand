using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LemonadeStand.ClassFiles.Game;

namespace LemonadeStand.ClassFiles.Game.Store
{
    public static class Store
    {
        //memb vars
        //public static Player player;

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
            bool leaveStore = false;

            do
            {
                //do Store things
                Console.WriteLine("Please buy something.");
                Console.ReadLine();
                Console.WriteLine("0 - Buy lemons.");
                Console.WriteLine("1 - Buy sugar cubes.");
                Console.WriteLine("2 - Buy ice cubes.");
                Console.WriteLine();
                Console.WriteLine("9 - Leave the store.");

                string tempInput = "";

                try
                {
                    tempInput = Console.ReadLine();
                }
                catch(Exception)
                {
                    tempInput = "9";
                }

                switch (tempInput)
                {

                    case ("0"):
                        BuyStuff("lemon");
                        break;
                    case ("1"):
                        BuyStuff("sugarCube");
                        break;
                    case ("2"):
                        BuyStuff("iceCube");
                        break;
                    case ("9"):
                        leaveStore = true;
                        break;
                    default:
                        break;
                }

            } while (!leaveStore);

        }     
        
        private static void BuyStuff(string itemToBuy)
        {
            switch (itemToBuy)
            {
                case "lemons":
                    Console.WriteLine("You bought then lemon.");
                    break;
                case "sugarCube":
                    Console.WriteLine("You bought the sugar cube.");
                    break;
                case "iceCube":
                    Console.WriteLine("You bought the ice cube.");
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
