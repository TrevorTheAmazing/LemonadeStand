using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LemonadeStand.ClassFiles.Game;

namespace LemonadeStand
{
    class Program
    {        
        static void Main(string[] args)
        {
            //Console.WriteLine("test");
            //Console.ReadLine();
            Game game = new Game();
            game.PlayGame();
        }
    }
}
