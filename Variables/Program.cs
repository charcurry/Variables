using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variables:");
            Console.WriteLine("----------");
            Console.WriteLine();

            //declaring variables as int/string and initializing them
            int score = 0;
            int enemyValue = 1000;
            float percentile = (943005f/5452256f) * 100f;

            string realName = "Charlie Curry";
            string gamerTag = "Kickycaptain";

            //pretend gameplay
            score += enemyValue;

            //hud
            Console.WriteLine(realName + " " + gamerTag);
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Percentile Rank: " + percentile);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
