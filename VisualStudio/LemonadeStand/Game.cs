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
        private bool playerIsSetUp = false;
        Player player = new Player();
        public int tempYes;
        public int tempNo;
        Random random = new Random();

        public Game()
        {
            random = new Random();
            do
            {
                SetupGame(random);                
            } while (!gameIsSetUp);

            if (gameIsSetUp)
            {
                //start the game
                PlayGame();
            }

            Console.WriteLine("Game is now over.  Thank you for playing!  yay");
            
        }

        //memb meths
        public void SetupGame(Random randomIn)
        {
            //set up player
            playerIsSetUp = false;
            //Player player = new Player();

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

            Console.Clear();
            Console.WriteLine("You return from the store." + Environment.NewLine + Environment.NewLine + 
                "Now you must prepare your recipe!" + Environment.NewLine +  "Only then will you have lemonade to sell.");
            Console.WriteLine("");
            Console.WriteLine(player.RecipeReport());

            Console.WriteLine("");
            Console.WriteLine("You attempt to make lemonade.");

             if (player.MakeLemonade())
                {
                    playerIsSetUp = true;
                Console.WriteLine("");
                Console.WriteLine("You successfully made the L E M O N A D E.");
                Console.WriteLine("");
            }
            else
                {
                    Console.WriteLine("You have insufficient L E M O N A D E.  You will need lemonade to sell.");
                }

            //set up days
            //create a Day list with 7 Day items having a temperature
            for (int i = 0; i < 7; i++)
            {
                days.Add(new Day.Day(random));
            }

            currentDay = 0;

            Console.WriteLine(days[currentDay].weather.WeatherReport());

            Console.WriteLine("Tomorrow's weather is predicted to be: " + (days[currentDay].weather.predictedForecast) + ".");
            Console.ReadKey();

            gameIsSetUp = true;
        }

        public void PlayGame(/*Player playerIn*/)
        {
            //player = playerIn;
            Console.WriteLine("PLAY GAME NOW!!");
            Console.ReadLine();
            for (int i = 0; i<days.Count; i++)
            {
                //display the current day
                currentDay = i;
                Console.WriteLine("Day #" + (currentDay + 1));
                tempYes = 0;
                tempNo = 0;

                //begin the day's countdown timer
                //fire off a number of 'interaction' events based on the day.weather.happinessIndex?
                //step through the current day's customers
                for (int j = 0; j < days[currentDay].customers.Count; j++)
                {
                    //if custy will buy and has an .internalResistance <=the day.weather's .hapIDX))
                    //if ((days[currentDay].customers[j].willPurchase) && 
                    //    (days[currentDay].customers[j].internalResistance <= days[currentDay].weather.happinessIndex))
                    if (days[currentDay].customers[j].willPurchase)
                    {
                        //verify that recipe meets or exceeds customer preference
                        if (player.recipe.amountOfLemons >= days[currentDay].customers[j].customerPreferences.amountOfLemons &&
                            player.recipe.amountOfSugarCubes >= days[currentDay].customers[j].customerPreferences.amountOfSugarCubes &&
                            player.recipe.amountOfIceCubes >= days[currentDay].customers[j].customerPreferences.amountOfIceCubes)
                        {
                            //SellLemonade();
                            tempYes++;
                        } 
                        else
                        {
                            //Console.WriteLine("no lemonade.");
                            tempNo++;
                        }
                    }
                }
                //day coundown timer ends?
                //generate daily p&L report (revenue, profit, gross sales, num of cst int, num of successful interactions)
                //add daily p&L to grand total
                Console.WriteLine("end of day" + (currentDay+1));
                Console.WriteLine("tempYes = " + tempYes);
                Console.WriteLine("tempNo = " + tempNo);
                Console.ReadLine();
            }
        }

        public void SellLemonade(/*Player playerIn*/)
        {
            //Console.WriteLine("L E M O N A D E  y'all");
//            Player = playerIn;
            //PURCHASE aka SALE
            //inc player.wallet.money
            
                    //burn a cup
                    //decrement pitcher.cupsRemain
        }
    }
}
