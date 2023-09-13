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

            //declaring variable 'score' as type integer
            int score;

            //initializing score
            score = 0;

            //pretend gameplay
            score += 100;

            //hud
            Console.WriteLine("Score: " + score);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
