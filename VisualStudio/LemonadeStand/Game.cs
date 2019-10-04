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
        Random random = new Random();
        ClassFiles.Game.Store.Store store;
        //public int cupsSold;
        public double tempRevenue;
        public double weeklySales;
        public int customerInteractions;
        public int positiveInteractions;
        public int negativeInteractions;
        public int pitchersToday;

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
            //ClassFiles.Game.Store.Store store = new Store.Store(player);
            playerIsSetUp = false;
            //Player player = new Player();

            //set the player's name
            Console.WriteLine("Hello, Player.  Welcome to '.oO0 - L E M O N A D E Stand' game!");
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
            store = new Store.Store(player);
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
                    Console.WriteLine("You successfully made the  .oO0 - L E M O N A D E.");
                    Console.WriteLine("");
            }
            else
                {
                    Console.WriteLine("You have insufficient .oO0 - L E M O N A D E.  You will need lemonade to sell.");
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
            weeklySales = 0;
            //player = playerIn;
            Console.WriteLine("PLAY GAME NOW!!");
            Console.ReadLine();
            for (int i = 0; i<days.Count; i++)
            {
                //display the current day
                currentDay = i;
                pitchersToday = 0;
                Console.WriteLine("Day #" + (currentDay + 1));
                tempRevenue = 0.0;
                customerInteractions = 0;
                positiveInteractions = 0;
                negativeInteractions = 0;

                //DO WEATHER REPORT
                Console.WriteLine(days[currentDay].weather.WeatherReport());

                //OPTION TO GO TO THE STORE
                Console.WriteLine("Would you like to go to the store?");
                if (Console.ReadLine()=="y")
                {
                    player = store.GoToTheStore();
                }

                //MAKE THE LEMONADE
                if (player.MakeLemonade())
                {
                    pitchersToday = 1;
                    Console.WriteLine("");
                    Console.WriteLine("You successfully made the L E M O N A D E.");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("You have insufficient L E M O N A D E.  You will need lemonade to sell.");
                    //OPTION TO GO TO THE STORE
                    Console.WriteLine("Would you like to go to the store?");
                    if (Console.ReadLine() == "y")
                    {
                        player = store.GoToTheStore();
                    }
                }




                //DO THE DAY

                //begin the day's countdown timer
                //fire off a number of 'interaction' events based on the day.weather.happinessIndex?
                //step through the current day's customers
                for (int j = 0; j < days[currentDay].customers.Count; j++)
                {

                //cupsSold = 0;


                    //if custy will buy and has an .internalResistance <=the day.weather's .hapIDX))
                    if (days[currentDay].customers[j].willPurchase)
                    {
                        customerInteractions++;
                        
                        if ((days[currentDay].customers[j].internalResistance <= 
                             days[currentDay].weather.happinessIndex))
                        { 
                            //verify that recipe meets or exceeds customer preference
                            if (player.recipe.amountOfLemons >= days[currentDay].customers[j].customerPreferences.amountOfLemons &&
                                player.recipe.amountOfSugarCubes >= days[currentDay].customers[j].customerPreferences.amountOfSugarCubes &&
                                player.recipe.amountOfIceCubes >= days[currentDay].customers[j].customerPreferences.amountOfIceCubes)
                            {
                                if (SellLemonade())
                                {
                                    positiveInteractions++;
                                }
                                else
                                {
                                    Console.WriteLine("no lemonade.");
                                    negativeInteractions++;
                                }
                            }
                        }
                    }
                }
                //day coundown timer ends?







                Console.WriteLine("end of day" + (currentDay+1));
                Console.WriteLine("");
                Console.WriteLine("You *DUMP* the remaining liquids from the pitcher.");
                Console.WriteLine("You do not serve liquid remnants!");
                Console.WriteLine("");

                //DUMP REMAINING PRODUCT
                //this represents LOSS
                int cupsDumped = player.pitcher.cupsLeftInPitcher;
                //dump it - dont serve leftovers
                player.pitcher.cupsLeftInPitcher = 0;
                int numCust = days[currentDay].customers.Count();
                double tempRecipeCost = player.GetRecipeCost();
                tempRevenue = positiveInteractions * player.recipe.pricePerCup;
                double tempLoss = ((positiveInteractions * player.inventory.cups[0].itemPrice) + //cups frmo sales
                    (cupsDumped*player.recipe.pricePerCup));
                double tempProfit = tempRevenue - (tempRecipeCost * pitchersToday) - tempLoss;




                
                //add daily gross sales to TOTAL SCORE FOR THE WEEK
                weeklySales += tempRevenue;

                //generate daily p&L report (revenue, profit, gross sales, num of cst int, num of successful interactions)

                player.DailyReport(tempRevenue, tempProfit, tempLoss, cupsDumped, numCust, positiveInteractions, negativeInteractions );
                


                Console.ReadLine();
            }
        }

        public bool SellLemonade(/*Player playerIn*/)
        {
            bool success = false;

            //TODO "CustomerWillBuyLemonade()" and "PlayerCanSellLemonade()"
            try
            {
                //burn a cup, decrement pitcher.cupsRemain
                player.inventory.cups.RemoveAt(0);
                if (player.pitcher.DispenseBeverage())
                {
                    success = true;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("***CANNOT SELL LEMONADE!");
                    Console.WriteLine("");
                    Console.WriteLine("You have exhausted your supply of .oO0 - L E M O N A D E!");

                    Console.WriteLine("");
                    Console.WriteLine("Would you like to create more  .oO0 - L E M O N A D E ?");

                    if (Console.ReadLine() == "y")
                    {
                        if (player.MakeLemonade())
                        {
                            Console.WriteLine("You have upset this customer, but you are forgiven because this one is 'on the house.'");
                            success = true;
                        }
                        else
                        {
                            Console.WriteLine("No ingredients YOU LOSE1!!");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("FAILURE 12c");
                        Console.ReadLine();
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("");
                Console.WriteLine("***CANNOT SELL LEMONADE!");
                Console.WriteLine("You have exhausted your supply of cups!");
                Console.WriteLine("The store is closed for the day.");
                Console.WriteLine("Buy more stuff tomorrow!");
                Console.WriteLine("");
            }
            finally
            {
                if (success)
                {
                    player.wallet.AdjustMoney(true, player.recipe.pricePerCup);
                    Console.WriteLine(".oO0 - L E M O N A D E  y'all!");
                    //cupsSold++;
                }
                else
                {
                    //you lost the sale, inventory, and product
                    Console.WriteLine("");
                    Console.WriteLine("this customer is  A N G E R Y.");
                    Console.WriteLine("");
                }
            }

            return success;
        }
    }
}
