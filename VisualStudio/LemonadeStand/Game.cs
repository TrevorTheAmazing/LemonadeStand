using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LemonadeStand.ClassFiles.Game.Day;

namespace LemonadeStand.ClassFiles.Game
{
    public class Game
    {
        //memb vars
        Player player = new Player();
        List<LemonadeStand.ClassFiles.Game.Day.Day> days = new List<LemonadeStand.ClassFiles.Game.Day.Day>();
        public int currentDay;

        public Game()
        {
            //set up player
            Console.WriteLine("Hello, Player.  Please enter your name!");

            do
            {
                player.SetPlayerName();
            } while (!string.IsNullOrEmpty(player.name));
            
            //set up days
            //create a Day list with 7 Day items having a temperature
            for (int i = 0; i < 7; i++)
            {
                days.Add(new Day.Day());
            }

            //set up store when the player wants to use it
            
        }

        //memb meths


    }
}
