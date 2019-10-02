﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LemonadeStand.ClassFiles.PlayerItems;
using LemonadeStand.ClassFiles.Game.Store;

namespace LemonadeStand.ClassFiles.Game
{
    //class Player
    public class Player
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
            Console.WriteLine("enter the number of lemons in your recipe:");
            recipe.amountOfLemons = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter the number of sugar cubes in your recipe:");
            recipe.amountOfSugarCubes = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter the number of ice cubes in your recipe:");
            recipe.amountOfIceCubes = Int32.Parse(Console.ReadLine());


            //double tempRecipeCost = 0.0;
            //for 


            Console.WriteLine("enter the price per cup of your recipe:");
            recipe.pricePerCup = Double.Parse(Console.ReadLine());

        }

        public void SetPricePerCup()
        {
            double tempPrice = 0.0;
            Console.WriteLine("Please set the price per cup:");

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
