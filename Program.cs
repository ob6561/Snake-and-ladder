using System;

namespace Snake_and_ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snake and Ladder Game - UC4");
            Console.WriteLine("Player starts from position 0\n");
            Console.WriteLine("Dice range: 1 - 6");
            Console.WriteLine("Options:\n 0 - No Play\n 1 - Ladder\n 2 - Snake\n");

            int pos = 0;
            Random rnd = new Random();

            while (pos < 100)
            {
                Console.WriteLine($"\nPlayer at position: {pos}");

                int dice = rnd.Next(1, 7); // dice between 1 and 6
                Console.WriteLine($"Dice rolled: {dice}");

                int option = rnd.Next(0, 3); // 0 = No Play, 1 = Ladder, 2 = Snake
                switch (option)
                {
                    case 0:
                        Console.WriteLine("Option: No Play — Player stays in the same position.");
                        break;

                    case 1:
                        pos += dice;
                        if (pos > 100) pos = 100;
                        Console.WriteLine($"Option: Ladder — Player moves ahead by {dice} to position {pos}.");
                        break;

                    case 2:
                        pos -= dice;
                        if (pos < 0) pos = 0;
                        Console.WriteLine($"Option: Snake — Player moves behind by {dice} to position {pos}.");
                        break;
                }
            }

            Console.WriteLine("\n🎉 Player reached position 100! 🎉");
        }
    }
}
