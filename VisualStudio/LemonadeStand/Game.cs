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
        List<LemonadeStand.ClassFiles.Game.Day.Day> days = new List<LemonadeStand.ClassFiles.Game.Day.Day>();
        public int currentDay;
        private bool gameIsSetUp = false;

        public Game()
        {
            do
            {
                SetupGame();                
            } while (!gameIsSetUp);

            if (gameIsSetUp)
            {
                //start the game
                PlayGame();
            }

            Console.WriteLine("Game is now over.  Thank you for playing!  yay");
            
        }

        //memb meths
        public void SetupGame()
        {
            //set up player
            Player player = new Player();

            //set the player's name
            Console.WriteLine("Hello, Player.  Welcome to 'Lemonade Stand' game!");
            Console.WriteLine("");
            Console.WriteLine("Please enter your name!");

            do
            {
                player.SetPlayerName();
            } while (string.IsNullOrEmpty(player.name));

            Console.WriteLine();
            Console.WriteLine("Your name is now " + player.name + ".");         
            Console.WriteLine();

            //recipe and store setup
            Console.WriteLine("You will need to use a recipe to make lemonade.  Prepare to create your recipe!");
            Console.WriteLine("");

            //set the player's recipe
            player.SetRecipe();
            
            Console.WriteLine("You will need ingredient(s) to prepare your recipe.");
            Console.WriteLine("");
            Console.WriteLine("You can go to the store to buy supplies.  You will go to the store now.");
            Console.WriteLine("");
            Console.WriteLine("You will prepare your recipe upon your return.");
            Console.ReadLine();

            //set up the store
            ClassFiles.Game.Store.Store store = new Store.Store(player);
            player = store.GoToTheStore();
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("You return from the store." + Environment.NewLine + Environment.NewLine + 
                "Now you must prepare your recipe!" + Environment.NewLine +  "Only then will you have lemonade to sell.");
            Console.WriteLine("");
            Console.WriteLine(player.RecipeReport());

            //




            //set up days
            //create a Day list with 7 Day items having a temperature
            for (int i = 0; i < 7; i++)
            {
                days.Add(new Day.Day());
            }

            currentDay = 0;
            
            Console.WriteLine(days[currentDay].weather.WeatherReport());

            Console.WriteLine("Tomorrow's weather is predicted to be: " + (days[currentDay].weather.predictedForecast) + ".");
            Console.ReadKey();




            gameIsSetUp = true;
        }

        public void PlayGame()
        {
            Console.WriteLine("PLAY GAME NOW!!");
            Console.ReadLine();
            for (int i = 0; i<days.Count; i++)
            {
                currentDay = (i+1);
                Console.WriteLine("Day #" + currentDay);
            }
        }
    }
}
