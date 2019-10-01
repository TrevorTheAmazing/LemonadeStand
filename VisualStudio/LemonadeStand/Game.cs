using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LemonadeStand.ClassFiles.Game.Day;
using LemonadeStand.ClassFiles.Game.Store;

namespace LemonadeStand.ClassFiles.Game
{
    public class Game
    {
        //memb vars
        Player player = new Player();
        LemonadeStand.ClassFiles.Game.Store.Store store = new LemonadeStand.ClassFiles.Game.Store.Store();
        List<LemonadeStand.ClassFiles.Game.Day.Day> days = new List<LemonadeStand.ClassFiles.Game.Day.Day>();
        public int currentDay;

        public Game()
        {
            //set up player
            //set the player's name
            Console.WriteLine("Hello, Player.  Please enter your name!");

            do
            {
                player.SetPlayerName();
            } while (!string.IsNullOrEmpty(player.name));

            //set the player's recipe
            player.SetRecipe();

            //set up days
            //create a Day list with 7 Day items having a temperature
            for (int i = 0; i < 7; i++)
            {
                days.Add(new Day.Day());
            }

            //give the player the predicted forecast for the first day
            Console.WriteLine("The weather is predicted to be " + "PREDICTEDFORECAST" + "today.");
            Console.ReadKey();

            //set up store when the player wants to use it
            Console.WriteLine("You can go to the store to buy supplies.  You will go to the store now.");
            player.GoToTheStore();

        }

        //memb meths


    }
}
