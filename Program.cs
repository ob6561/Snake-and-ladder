using System;

namespace Snake_and_ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snake & Ladder - UC7 (Two Players)");
            Console.WriteLine("Rules:");
            Console.WriteLine(" - Start at 0. Dice 1..6.");
            Console.WriteLine(" - Options: 0=No Play, 1=Ladder (extra turn), 2=Snake.");
            Console.WriteLine(" - Must land EXACTLY on 100 to win; overshoot -> stay put.\n");

            int[] pos = new int[2];         // pos[0] = P1, pos[1] = P2 (start at 0)
            int[] rolls = new int[2];       // dice roll count per player
            int current = 0;                // 0 = Player 1, 1 = Player 2
            int turnNo = 0;                 // global turn counter (each dice throw increments)
            Random rnd = new Random();

            while (pos[0] < 100 && pos[1] < 100)
            {
                turnNo++;
                string playerName = current == 0 ? "Player 1" : "Player 2";

                int before = pos[current];

                // Roll dice
                int dice = rnd.Next(1, 7);
                rolls[current]++;

                // Pick option
                int option = rnd.Next(0, 3); // 0=No Play, 1=Ladder, 2=Snake
                string optionText = option == 0 ? "No Play" : option == 1 ? "Ladder" : "Snake";

                // Apply move with exact-100 rule
                int after = before;
                if (option == 1)            // Ladder
                {
                    if (before + dice <= 100)
                        after = before + dice;   // valid climb
                    // else stay (need exact roll)
                }
                else if (option == 2)       // Snake
                {
                    after = Math.Max(0, before - dice);
                }
                // option==0 -> No Play -> after == before

                pos[current] = after;

                // Per-turn log
                Console.WriteLine(
                    $"Turn {turnNo}: {playerName} | Dice={dice}, Option={optionText}, Position: {before} -> {after}"
                );

                // Check win
                if (pos[current] == 100)
                {
                    Console.WriteLine($"\n🎉 {playerName} WINS! 🎉");
                    Console.WriteLine($"Rolls: Player 1 = {rolls[0]}, Player 2 = {rolls[1]}");
                    break;
                }

                // Turn logic: Ladder grants extra turn; otherwise switch player
                if (option != 1)
                {
                    current = 1 - current; // switch 0 <-> 1
                }
                // else: same player goes again
            }
        }
    }
}
