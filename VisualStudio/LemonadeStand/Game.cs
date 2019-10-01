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
            string tempName = "";

            //begin the game
            Console.WriteLine("now in Game()");
            Console.WriteLine("Hello, Player.  Please enter your name!");
            do
            {
                player.SetPlayerName();
            } while (!string.IsNullOrEmpty(player.name));
            
            //create a Day list with 7 Day items having a temperature
            for (int i = 0; i < 7; i++)
            {
                days.Add(new Day.Day());
            }
            
        }
        
        //memb meths



    }
}
