using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_and_ladder
{
    internal class UC3_Playing_rules
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Player at 0th position");
            int pos = 0;
            Random random = new Random();
            int diceRoll = random.Next(1, 7);
            Console.WriteLine("Dice rolled: " + diceRoll);
            int option = random.Next(0, 3); // 0: No Play, 1: Ladder, 2: Snake
            switch (option)
            {
                case 0:
                    Console.WriteLine("No Play. Player stays at the same position: " + pos);
                    break;
                case 1:
                    pos += diceRoll;
                    Console.WriteLine("Ladder! Player moves up to position: " + pos);
                    break;
                case 2:
                    pos -= diceRoll;
                    if (pos < 0) pos = 0; // Ensure position doesn't go below 0
                    Console.WriteLine("Snake! Player moves down to position: " + pos);
                    break;
            }
        }  
    }
}
