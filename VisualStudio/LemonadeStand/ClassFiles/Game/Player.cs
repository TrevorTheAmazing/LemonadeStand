﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LemonadeStand.ClassFiles.PlayerItems;
using LemonadeStand.ClassFiles.Game.Store;
using LemonadeStand.ClassFiles.Items;

namespace LemonadeStand.ClassFiles.Game
{
    //class Player
    public class Player
    {
        //memb vars
        public string name;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;
        public double businessProfits;
        public double recipeCost;

        public Player()
        {
            name = "";
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
            pitcher = new Pitcher();
            businessProfits = 0.00;
            recipeCost = 0.00;
        }

        //memb meths
        public void SetPlayerName()
        {
            string tempPlayerName = "";
            try
            {
                tempPlayerName = Console.ReadLine();
            }
            catch (Exception)
            {
                //tempPlayerName = "Name of Player";
                SetPlayerName();
            }
            finally
            {
                if (!string.IsNullOrEmpty(tempPlayerName))
                {
                    this.name = tempPlayerName;
                    //return tempPlayerName;
                }
                else
                {
                    SetPlayerName();
                    //return "";
                }
            }

            //return tempPlayerName;
        }

        public void SetRecipe()
        {
            Console.WriteLine("enter the number of lemons in your recipe:");
            recipe.amountOfLemons = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter the number of sugar cubes in your recipe:");
            recipe.amountOfSugarCubes = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter the number of ice cubes in your recipe:");
            recipe.amountOfIceCubes = Int32.Parse(Console.ReadLine());

            Console.WriteLine("enter the price per cup of your recipe:");
            recipe.pricePerCup = Double.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

        }

        public void SetPricePerCup()
        {
            double tempPrice = 0.0;
            Console.WriteLine("How much would you like to charge per cup?");

            try
            {
                tempPrice = Double.Parse(Console.ReadLine());
            }
            catch(Exception)
            {
                tempPrice = -1.0;
            }
            finally
            {
                if (tempPrice > 0.0)
                {
                    recipe.pricePerCup = tempPrice;
                }
                else
                {
                    SetPricePerCup();
                }
            }
        }

        public string RecipeReport()
        {
            return (GetRecipe() + Environment.NewLine +
                "You will charge $" + recipe.pricePerCup + " per cup.");

        }

        private string GetRecipe()
        {
            string tempRecipe = ("Your recipe calls for " +
                recipe.amountOfLemons.ToString() + " lemons, " +
                recipe.amountOfSugarCubes.ToString() + " sugar cubes, and " +
                recipe.amountOfIceCubes.ToString() + " ice cubes.");

            return tempRecipe;
        }

        public double GetRecipeCost()
        {
            Lemon tempLemon = new Lemon();
            IceCube tempIceCube = new IceCube();
            SugarCube tempSugarCube = new SugarCube();
            double priceOfLemons = ((recipe.amountOfLemons) * (tempLemon.itemPrice));
            double priceOfSugarCubes = ((recipe.amountOfSugarCubes) * (tempSugarCube.itemPrice));
            double priceOfIceCubes = ((recipe.amountOfIceCubes) * (tempIceCube.itemPrice));

            return (priceOfLemons + priceOfSugarCubes + priceOfIceCubes);
        }

        public string InventoryReport()
        {
            string tempInventory = "You have " + inventory.lemons.Count + " lemons, " + 
                inventory.sugarCubes.Count + " sugar cubes, and " + 
                inventory.iceCubes.Count + " ice cubes." + Environment.NewLine + 
                "You also have " + inventory.cups.Count + " cups.";

            return tempInventory;
        }

        public bool MakeLemonade()
        {
            //check quantities on hand prior to reducing inventory
            if ((inventory.lemons.Count >= recipe.amountOfLemons) &&
                (inventory.sugarCubes.Count >= recipe.amountOfSugarCubes) &&
                (inventory.iceCubes.Count >= recipe.amountOfIceCubes))
            {
                //subtract recipe qty from inventory
                for (int i = 0; i < recipe.amountOfLemons; i++)
                {
                    inventory.lemons.RemoveAt(0);
                }

                for (int i = 0; i < recipe.amountOfSugarCubes; i++)
                {
                    inventory.sugarCubes.RemoveAt(0);
                }
                for (int i = 0; i < recipe.amountOfIceCubes; i++)
                {
                    inventory.iceCubes.RemoveAt(0);
                }

                //set pitcher.cupsLeft to 100
                pitcher.FillPitcher();
                return true;
            }
            else
            {
                return false;
            }                
        }
        
        public void DailyReport(double revenueIn, double profitIn, double tempLossIn, int cupsDumpedIn, int numCustIn, int positiveInteractionsIn, int negativeInteractionsIn )
        {
            Console.WriteLine("--DAILY REPORT--" + Environment.NewLine + 
                "Revenue: " + revenueIn.ToString() + Environment.NewLine + 
                "Profit: " + profitIn.ToString() + Environment.NewLine + 
                "Cups sold:" + positiveInteractionsIn.ToString() + Environment.NewLine + 
                "Cups dumped: " + cupsDumpedIn.ToString() + Environment.NewLine + 
                "Loss: " + tempLossIn.ToString() + Environment.NewLine +
                "Total Customers: " + numCustIn.ToString() + Environment.NewLine +
                "Negative Interactions: " + negativeInteractionsIn.ToString() + Environment.NewLine +
                "**END OF REPORT**" + Environment.NewLine + Environment.NewLine);
        }

    }
}
