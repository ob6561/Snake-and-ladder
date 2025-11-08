using System;

namespace Snake_and_ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snake and Ladder Game - UC5");
            Console.WriteLine("Rules:");
            Console.WriteLine(" - Player starts at 0");
            Console.WriteLine(" - Dice: 1 to 6");
            Console.WriteLine(" - Options: 0=No Play, 1=Ladder, 2=Snake");
            Console.WriteLine(" - Must land EXACTLY on 100 to win; if move goes beyond 100, stay put\n");

            int pos = 0;
            int diceRolls = 0;
            Random rnd = new Random();

            while (pos < 100)
            {
                Console.WriteLine($"\nPlayer at position: {pos}");

                int dice = rnd.Next(1, 7);   // 1..6
                diceRolls++;
                Console.WriteLine($"Dice rolled: {dice}");

                int option = rnd.Next(0, 3); // 0=No Play, 1=Ladder, 2=Snake
                switch (option)
                {
                    case 0:
                        Console.WriteLine("Option: No Play — position unchanged.");
                        break;

                    case 1:
                        // Ladder: move forward by dice, BUT must not exceed 100
                        int nextPos = pos + dice;
                        if (nextPos > 100)
                        {
                            Console.WriteLine($"Option: Ladder — need exact roll; {pos} + {dice} > 100, so stay at {pos}.");
                        }
                        else
                        {
                            pos = nextPos;
                            Console.WriteLine($"Option: Ladder — moved +{dice} to {pos}.");
                        }
                        break;

                    case 2:
                        // Snake: move backward by dice; not below 0
                        pos -= dice;
                        if (pos < 0) pos = 0;
                        Console.WriteLine($"Option: Snake — moved -{dice} to {pos}.");
                        break;
                }
            }

            Console.WriteLine($"\n🎉 Player reached EXACTLY 100! Total dice rolls: {diceRolls} 🎉");
        }
    }
}
