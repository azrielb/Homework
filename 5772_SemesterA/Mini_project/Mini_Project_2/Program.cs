using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace War
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the names of tow users. Press \"Enter\" after each name.");
            Game myGame = new Game(Console.ReadLine(), Console.ReadLine());
            do
            {
                Console.WriteLine(myGame);
                myGame.makeStep();
            } while (!myGame.isEnded());
            Console.WriteLine("\nGame over. The winner is {0}.\nGood bye...", myGame.winner());
        }
    }
}
