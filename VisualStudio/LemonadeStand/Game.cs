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
            Console.WriteLine("Hello, Player.  Please enter your name!");

            do
            {
                player.SetPlayerName();
            } while (string.IsNullOrEmpty(player.name));

            Console.WriteLine();
            Console.WriteLine("Your name is now " + player.name + ".");
            Console.WriteLine();
            Console.WriteLine();

            //set the player's recipe
            Console.WriteLine("You will need to use a recipe to make lemonade.");
            Console.WriteLine();
            Console.WriteLine("Please create a recipe now!");
            Console.WriteLine();
            Console.WriteLine();
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


            //set up the store
            Console.WriteLine("You can go to the store to buy supplies.  You will go to the store now.");
            Console.ReadKey();

            ClassFiles.Game.Store.Store store = new Store.Store(player);
            player = store.GoToTheStore();

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


                //sunny day: at least 60~100 customer encounters
                //cloudy day: at least 40~80 custy enc, even nums only (counterSeconds%2==0)
                //rainy: at least 20~70, odd nums only (counterSeconds%3==0)
                //use random to get the daily number of custy enc
                //assign it to the day locally?
                //divide countdown timer by custy enc
                    //there needs to be that many custy enc events
                //start the day countdown timer
                    //when it is time for the encounter event
                        //the custy will buy if they 'roll a d6 3 times' and beat the 'magic score'
                        //'magic score index' to be set according to weather?
                            //lowerd one point for each sugar cube in the recipe
            }
        }
    }
}
