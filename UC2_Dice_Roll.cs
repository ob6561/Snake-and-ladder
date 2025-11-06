using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_and_ladder
{
    internal class UC2_Dice_Roll
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Player at 0th position");
            int pos = 0;
            Random random = new Random();
            int diceRoll = random.Next(1, 7);
            Console.WriteLine("Dice rolled: " + diceRoll);
        }
    }
}
