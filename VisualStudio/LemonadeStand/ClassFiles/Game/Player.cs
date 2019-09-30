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
        public string Name;
        public bool isAtStore;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;
        public double businessProfits;

        public Player()
        {
            Name = "Name of Player";
            isAtStore = false;
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
            pitcher = new Pitcher();
            businessProfits = 0.00;
        }

        //memb meths
        //SetPlayerName()
        //GoToStore()
        //
    }
}
