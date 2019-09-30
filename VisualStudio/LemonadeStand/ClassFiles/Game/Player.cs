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
        public bool isAtStore;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;
        public double businessProfits;

        public Player()
        {
            name = SetPlayerName();
            isAtStore = false;
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
            pitcher = new Pitcher();
            businessProfits = 0.00;
        }

        //memb meths
        public string SetPlayerName()
        {
            string tempPlayerName = "";
            try
            {
                tempPlayerName = Console.ReadLine();
            }            
            catch
            {
                tempPlayerName = "Player Name try(catch)";
            }
            tempPlayerName = "Name of Player";
            return tempPlayerName;
        }

        //GoToStore()
        //
    }
}
