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
        //Player player = new Player();
//        LemonadeStand.ClassFiles.Game.Store.Store store = new LemonadeStand.ClassFiles.Game.Store.Store();
        List<LemonadeStand.ClassFiles.Game.Day.Day> days = new List<LemonadeStand.ClassFiles.Game.Day.Day>();
        public int currentDay;

        public Game()
        {
            SetupGame();
        }

        //memb meths

        public void SetupGame()
        {
            //set up player
            Player player = new Player();

            //set the player's name
            Console.WriteLine("Hello, Player.  Please enter your name!");

            do
            {
                player.SetPlayerName();
            } while (string.IsNullOrEmpty(player.name));

            Console.WriteLine();
            Console.WriteLine("Your name is now " + player.name + ".");
            Console.WriteLine();

            //set the player's recipe
            Console.WriteLine("You will need to use a recipe to make lemonade.");
            Console.WriteLine("Please create a recipe now!");
            player.SetRecipe();

            //set up days
            //create a Day list with 7 Day items having a temperature
            for (int i = 0; i < 7; i++)
            {
                days.Add(new Day.Day());
            }

            //give the player the predicted forecast for the first day
            Console.WriteLine("Today's weather was predicted to be " + (days[0].weather.predictedForecast) + ".");
            Console.ReadKey();

            //set up store when the player wants to use it
            Console.WriteLine("You can go to the store to buy supplies.  You will go to the store now.");
            Console.ReadKey();

            do
            {
                player.GoToTheStore();
            } while (!player.IsAtStore);

            //option to set price per cup
            Console.WriteLine("Would you like to set the price per cup?");
            if (Console.ReadLine() == "y")
            {
                player.SetPricePerCup();
            }


            //start the game
            PlayGame();
        }

        public void PlayGame()
        {
            Console.WriteLine("PLAY GAME NOW!!");
        }


    }
}
