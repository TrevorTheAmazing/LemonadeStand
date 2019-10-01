using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.ClassFiles.Game.Store
{
    public class Store
    {
        //memb vars
        Player player;

        //constructor
        public Store()
        {
            while (player.IsAtStore)
            {
                //do Store things
                Console.WriteLine("Please buy something.");
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

                //option to set price per cup
                Console.WriteLine("Would you like to adjust the price per cup?");
                if (Console.ReadLine()=="y")
                {
                    player.SetPricePerCup();
                }

                if (leaveStore)
                {
                    player.LeaveStore();
                }

            }
        }

        //memb meths
        //BuyStuff()
        //increase inventory
        //decrease money with 
    }
}
