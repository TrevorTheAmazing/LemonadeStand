﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LemonadeStand.ClassFiles.Game.Day;
using LemonadeStand.ClassFiles.Game.Store;
using LemonadeStand.ClassFiles;

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
        public bool burnTheDay;

        public Game(Random randomIn)
        {
            //random = new Random();
            random = randomIn;
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
            //Console.WriteLine("Please enter your name!");

            do
            {
                player.SetPlayerName();
            } while (string.IsNullOrEmpty(player.name));

            Console.WriteLine();
            Console.WriteLine("Your name is now " + player.name + ".");         
            Console.WriteLine();

            //recipe and store setup
            Console.WriteLine("You will need to use a recipe to make lemonade.  Prepare to create your recipe!");
            Console.ReadLine();
            //Console.WriteLine("");

            //set the player's recipe
            player.SetRecipe();
            
            Console.WriteLine("You will need ingredient(s) to prepare your recipe.");
            Console.ReadLine();
            //Console.WriteLine("");
            Console.WriteLine("You can go to the store to buy supplies.");
            Console.ReadLine();
            //Console.WriteLine("");
            Console.WriteLine("You will prepare your recipe upon your return.");
            Console.ReadLine();

            //set up the store
            store = new Store.Store(player);

            //Console.WriteLine("Would you like to go to the store now?");
            //if (Console.ReadLine()=="y")
            //{
            //    player = store.GoToTheStore();
            //}

            //RETURN FROM THE STORE //!//
            //Console.Clear();
            Console.WriteLine("You return from the store." + Environment.NewLine + Environment.NewLine + 
                "Now you must prepare your recipe!" + Environment.NewLine +  "Only then will you have lemonade to sell.");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine(player.RecipeReport());
            Console.WriteLine("");

            //Console.WriteLine("");
            /*Console.WriteLine("You attempt to make lemonade.");

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
                }*/

            //set up days
            //create a Day list with 7 Day items having a temperature
            for (int i = 0; i < 7; i++)
            {
                days.Add(new Day.Day(random));
            }

            currentDay = 0;

            //Console.WriteLine(days[currentDay].weather.WeatherReport());

            //Console.WriteLine("Tomorrow's weather is predicted to be: " + (days[currentDay].weather.predictedForecast) + ".");
            //Console.ReadKey();

            gameIsSetUp = true;
        }

        public void PlayGame(/*Player playerIn*/)
        {

            void EndOfDay()
            {
                Console.WriteLine("end of day" + (currentDay + 1));
                Console.WriteLine("");
                if (player.pitcher.cupsLeftInPitcher > 0)
                {
                    Console.WriteLine("You *DUMP* the remaining liquids from the pitcher;  you do not serve liquid remnants!");
                }
                else if (player.pitcher.cupsLeftInPitcher == 0)
                {
                    Console.WriteLine("Successful volumetric planning... nothing wasted!  But...");
                }
                Console.WriteLine("You will need to make more lemonade tomorrow.");
                Console.WriteLine("");
            }



            weeklySales = 0;
            //player = playerIn;
            //Console.WriteLine("PLAY GAME NOW!!");
            //Console.ReadLine();
            for (int i = 0; i < days.Count; i++)
            {
                //init the day
                burnTheDay = false;
                currentDay = i;
                pitchersToday = 0;
                tempRevenue = 0.0;
                customerInteractions = 0;
                positiveInteractions = 0;
                negativeInteractions = 0;
                
                Console.Clear();
                Console.WriteLine("GET READY FOR DAY# " + currentDay.ToString());
                Console.ReadLine();
                //display daily info: cur day, weather, store, make lemonade...
                Console.WriteLine("Day #" + (currentDay + 1));                
                Console.WriteLine(days[currentDay].weather.WeatherReport());
                Console.WriteLine("Tomorrow's conditions are predicted to be: " + days[currentDay].weather.WeatherPrediction() + ".");
                Console.ReadLine();

               
                if (Validation.GetUserInput("Would you like to go to the store?", "str")=="y")
                {
                    player = store.GoToTheStore();
                }
                //Console.WriteLine("Would you like to go to the store?");
                //if (Console.ReadLine() == "y")
                //{
                //    player = store.GoToTheStore();
                //}
                
                            //Console.WriteLine("");
                Console.WriteLine("You attempt to make lemonade for the day...");
                Console.WriteLine("");
                Console.ReadLine();
                bool lemonadeIsMade = false;
                do
                {                  
                    //MAKE THE LEMONADE
                    if (player.MakeLemonade())
                    {
                        //pitchersToday = 1;
                        pitchersToday++;
                        lemonadeIsMade = true;
                        Console.WriteLine("");
                        Console.WriteLine("You successfully made the L E M O N A D E.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("You have insufficient L E M O N A D E.  You will need lemonade to sell.");
                        //OPTION TO GO TO THE STORE
                        //Console.WriteLine("Would you like to go to the store?");
                        //if (Console.ReadLine() == "y")
                        if (Validation.GetUserInput("Would you like to go to the store?", "str") == "y")
                        {
                            player = store.GoToTheStore();
                        }
                    }
                } while (!lemonadeIsMade);




                //DO THE DAY
                Console.WriteLine("DAY# " + currentDay.ToString() + " begins... NOW!");
                Console.ReadLine();
                //begin the day's countdown timer?
                //fire off a number of 'interaction' events based on the day.weather.happinessIndex?
                
                //step through the current day's customers
                for (int j = 0; j < days[currentDay].customers.Count; j++)
                {
                    if (burnTheDay)
                    {
                        negativeInteractions++;
                        continue;
                    }

                    
                    //if the custy will even consider the purchase...
                    if (days[currentDay].customers[j].willPurchase)                    
                    {
                    customerInteractions++;

                        //if the customer is having a 'good day'
                        if ((days[currentDay].customers[j].internalResistance <= days[currentDay].weather.happinessIndex))
                        {
                            //verify that recipe meets or exceeds customer preference
                            if (player.recipe.amountOfLemons >= days[currentDay].customers[j].customerPreferences.amountOfLemons &&
                                player.recipe.amountOfSugarCubes >= days[currentDay].customers[j].customerPreferences.amountOfSugarCubes &&
                                player.recipe.amountOfIceCubes >= days[currentDay].customers[j].customerPreferences.amountOfIceCubes)
                            //if custy finds the the price to be 'acceptable'
                            {
                                if ((player.recipe.pricePerCup <= days[currentDay].customers[j].maxPurchasePrice))
                                { 
                                    if (SellLemonade())
                                    {
                                        positiveInteractions++;
                                        Console.WriteLine(days[currentDay].customers[j].name + " just bought some .oO0 - L E M O N A D E  y'all!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("no lemonade.");
                                        negativeInteractions++;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(days[currentDay].customers[j].name + ": Meh... cost is too dang high.");
                                }
                            }
                            else
                            {
                                Console.WriteLine(days[currentDay].customers[j].name + " says 'yuck.'");
                            }
                        }
                        else
                        {
                            Console.WriteLine(days[currentDay].customers[j].name + " just ain't feelin' it today.");
                        }
                    }
                    else
                    {
                        Console.WriteLine(days[currentDay].customers[j].name + " does not even want lemonade.");
                    }
                }
                //day coundown timer ends?







                //Console.WriteLine("end of day" + (currentDay + 1));
                //Console.WriteLine("");
                //Console.WriteLine("You *DUMP* the remaining liquids from the pitcher;  you do not serve liquid remnants!");
                //Console.WriteLine("You will need to make more lemonade tomorrow.");
                //Console.WriteLine("");
                EndOfDay();

                //DUMP REMAINING PRODUCT
                //this represents LOSS
                int cupsDumped = player.pitcher.cupsLeftInPitcher;
                //dump it - dont serve leftovers
                player.pitcher.cupsLeftInPitcher = 0;
                int numCust = days[currentDay].customers.Count(); //this is actually TOTAL FOOT TRAFFIC, numCust = custyInt, posInt = sold a cup, negInt = pissy custy
                double tempRecipeCost = player.GetRecipeCost();
                tempRevenue = positiveInteractions * player.recipe.pricePerCup;
                double tempLoss = ((positiveInteractions * player.inventory.cups[0].itemPrice) + //cups frmo sales
                    (cupsDumped * player.recipe.pricePerCup));
                double tempProfit = tempRevenue - (tempRecipeCost * pitchersToday) - tempLoss;
                if (tempProfit < 0)
                {
                    tempProfit = 0.0;
                }

                //add daily gross sales to TOTAL SCORE FOR THE WEEK
                weeklySales += tempRevenue;

                //generate daily p&L report 
                player.DailyReport(tempRevenue, tempProfit, tempLoss, cupsDumped, numCust, positiveInteractions, negativeInteractions);

                Console.ReadLine();
            }

            //GAME OVER
            Console.WriteLine("Good game, " + player.name + "!");
            Console.ReadLine();
            Console.WriteLine("You generated $" + weeklySales.ToString() + " USD dollars in gross sales for the week!");
            Console.ReadLine();
            Console.WriteLine("game over you win.");

        }
        public bool SellLemonade(/*Player playerIn*/)
        {
            void CannotSellLemonade()
            {
                Console.WriteLine("");
                Console.WriteLine("***CANNOT SELL LEMONADE!");
                Console.WriteLine("");                
            }

            void StoreIsClosed()
            {
                Console.WriteLine("The store is closed for the day.");
                Console.WriteLine("Buy more stuff tomorrow!");
                Console.WriteLine("");
            }

            void BurnTheDay()
            {
                Console.WriteLine("Press enter to skip the rest of this day.");
                Console.ReadLine();
                burnTheDay = true;
            }

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
                    CannotSellLemonade();
                    Console.WriteLine("You have exhausted your supply of .oO0 - L E M O N A D E!");
                    Console.WriteLine("");
                    //Console.WriteLine("Would you like to combine your inventory items to create more lemonade?");

                    //if (Console.ReadLine() == "y")
                    if (Validation.GetUserInput("Would you like to combine your inventory items to create more lemonade?", "str")=="y")
                    {
                        if (player.MakeLemonade())
                        {
                            pitchersToday++;
                            if (player.pitcher.DispenseBeverage())
                            {
                                
                            
                            Console.WriteLine("You have upset this customer, but you are forgiven because this one is 'on the house.'");
                            success = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("No ingredients!!");
                            StoreIsClosed();
                            BurnTheDay();
                        }
                    }
                    else
                    {
                        StoreIsClosed();
                        BurnTheDay();
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                CannotSellLemonade();
                Console.WriteLine("You have exhausted your supply of cups!");
                StoreIsClosed();
            }
            finally
            {
                if (success)
                {
                    player.wallet.AdjustMoney(true, player.recipe.pricePerCup);
                }
                else
                {
                    //you lost the sale, inventory, and/or product
                    Console.WriteLine("");
                    Console.WriteLine("this customer is  A N G E R Y.");
                    Console.WriteLine("");
                }
            }

            return success;
        }
    }
}
