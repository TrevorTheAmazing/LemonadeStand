using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LemonadeStand.ClassFiles.PlayerItems;

namespace LemonadeStand.ClassFiles.Game
{
    class Player
    {
        //memb vars
        public string name;
        //public static Store.Store;
        //public bool isAtStore;
        private bool isAtStore;
        public bool IsAtStore
        {
            get => isAtStore;
        }
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;
        public double businessProfits;

        public Player()
        {
            //name = SetPlayerName();
            name = "";
            isAtStore = false;
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
            pitcher = new Pitcher();
            businessProfits = 0.00;
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
            Console.WriteLine("enter the number of lemons:");
            recipe.amountOfLemons = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter the number of sugar cubes:");
            recipe.amountOfSugarCubes = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter the number of ice cubes:");
            recipe.amountOfIceCubes = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter the price per cup:");
            recipe.pricePerCup = Double.Parse(Console.ReadLine());
        }

        public void GoToTheStore()
        {
            Console.WriteLine("You are now at the store.");
            //store.OpenStore();
            isAtStore = true;
            Store.Store.OpenStore();
        }
        public void LeaveStore()
        {
            Console.WriteLine("You leave the store.");
            isAtStore = false;
        }

        public void SetPricePerCup()
        {
            double tempPrice = 0.0;
            Console.WriteLine("Enter the new price per cup:");

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
    }
}
