using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LemonadeStand.ClassFiles.Game;
using LemonadeStand.ClassFiles.PlayerItems;
using LemonadeStand.ClassFiles.Items;

namespace LemonadeStand.ClassFiles.Game.Store
{
    public class Store
    {
        //memb vars
        Player player;
        public Inventory inventory;

        //constructor
        public Store(Player player)
        {
            this.player = player;
        }

        //memb meths       
        //public store 'interface', private store methods
        public Player GoToTheStore()
        {
            bool leaveStore = false;

            Console.Clear();

            do
            {
                double tempMoney = player.wallet.CountMoney();
                //do Store things
                Console.WriteLine("You appear at the store.");
                Console.WriteLine("");
                Console.WriteLine("You have $" + tempMoney.ToString() + " money.");
                Console.WriteLine("");

                //INVENTORY REPORT HERE
                Console.WriteLine(player.InventoryReport());
                Console.WriteLine("");

                Lemon tempLemon = new Lemon();
                double lemonPurchQty = 10;
                Console.WriteLine("0 - Buy lemons.  " + lemonPurchQty + " for " + (tempLemon.itemPrice * lemonPurchQty).ToString());

                SugarCube tempSugarCube = new SugarCube();
                double sugarCubePurchQty = 144;
                Console.WriteLine("1 - Buy sugar cubes.  " + sugarCubePurchQty.ToString() + " for " + (tempSugarCube.itemPrice * sugarCubePurchQty).ToString());

                IceCube tempIceCube = new IceCube();
                double iceCubePurchQty = 120;
                Console.WriteLine("2 - Buy ice cubes.  " + iceCubePurchQty.ToString() + " for " + (tempIceCube.itemPrice * iceCubePurchQty).ToString());

                Cup tempCup = new Cup();
                double cupPurchQty = 50;
                Console.WriteLine("3 - Buy cups.  " + cupPurchQty.ToString() + " for " + (tempCup.itemPrice * cupPurchQty).ToString());

                Console.WriteLine("");
                Console.WriteLine("9 - Purchase nothing more.  Leave the store.");
                Console.WriteLine("");
                Console.WriteLine("");

                //recipe report
                Console.WriteLine(player.RecipeReport());
                Console.WriteLine("");
                Console.WriteLine("What would you like to purchase from the store?");

                //get user's selection
                string tempInput = "";
                try
                {
                    tempInput = Console.ReadLine();
                }
                catch (Exception)
                {
                    tempInput = "9";
                }

                //find the item the player wants to buy in the list
                switch (tempInput)
                {

                    case ("0"):
                        SellStuff("lemon");
                        break;
                    case ("1"):
                        SellStuff("sugarCube");
                        break;
                    case ("2"):
                        SellStuff("iceCube");
                        break;
                    case ("3"):
                        SellStuff("cup");
                        break;
                    case ("9"):
                        leaveStore = true;
                        break;
                    default:
                        break;
                }

                if (leaveStore)
                {
                    break; 
                }
                else
                {
                    GoToTheStore();
                }

            } while (!leaveStore);

            LeaveTheStore();
            return player;
        }

        private void SellStuff(string itemToBuy)
        {
            switch (itemToBuy)
            {
                case "lemon":
                    Lemon tempLemon = new Lemon();
                    if (player.wallet.Money >= tempLemon.itemPrice)
                    {
                        player.wallet.AdjustMoney(false, tempLemon.itemPrice);
                        player.inventory.lemons.Add(tempLemon);
                        Console.WriteLine("You bought 'lemon.'");
                    }
                    break;
                case "sugarCube":
                    SugarCube tempSugarCube = new SugarCube();
                    if (player.wallet.Money >= tempSugarCube.itemPrice)
                    {
                        player.wallet.AdjustMoney(false, tempSugarCube.itemPrice);
                        player.inventory.sugarCubes.Add(tempSugarCube);
                        Console.WriteLine("You bought 'sugar cube.'");
                    }
                    break;
                case "iceCube":
                    IceCube tempIceCube = new IceCube();
                    if (player.wallet.Money >= tempIceCube.itemPrice)
                    {
                        player.wallet.AdjustMoney(false, tempIceCube.itemPrice);
                        player.inventory.iceCubes.Add(tempIceCube);
                        Console.WriteLine("You bought 'ice cube.'");
                    }
                    break;
                case "cup":
                    Cup tempCup = new Cup();
                    if (player.wallet.Money >= tempCup.itemPrice)
                    {
                        player.wallet.AdjustMoney(false, tempCup.itemPrice);
                        player.inventory.cups.Add(tempCup);
                        Console.WriteLine("You bought 'cup.'");
                    }
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }//end SellStuff

        private void LeaveTheStore()
        {
            Console.WriteLine("Now set the price per cup!");
            player.SetPricePerCup();
        }
    }
}
