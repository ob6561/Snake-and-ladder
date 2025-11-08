using System;

namespace Snake_and_ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snake and Ladder Game - UC6");
            Console.WriteLine("Rules:");
            Console.WriteLine(" - Player starts at 0");
            Console.WriteLine(" - Dice: 1 to 6");
            Console.WriteLine(" - Options: 0=No Play, 1=Ladder, 2=Snake");
            Console.WriteLine(" - Must land EXACTLY on 100 to win; if a move goes beyond 100, stay put\n");

            int pos = 0;
            int diceRolls = 0;
            Random rnd = new Random();

            // Play until we reach EXACTLY 100
            while (pos < 100)
            {
                int before = pos;

                // Roll dice
                int dice = rnd.Next(1, 7);   // 1..6
                diceRolls++;

                // Pick option
                int option = rnd.Next(0, 3); // 0=No Play, 1=Ladder, 2=Snake

                string optionText;
                switch (option)
                {
                    case 0: // No Play
                        optionText = "No Play";
                        // pos unchanged
                        break;

                    case 1: // Ladder (forward), but respect exact-100 rule
                        optionText = "Ladder";
                        if (before + dice <= 100)
                            pos = before + dice;
                        // else stay at 'before'
                        break;

                    default: // 2: Snake (backward, not below 0)
                        optionText = "Snake";
                        pos = Math.Max(0, before - dice);
                        break;
                }

                // Enforce exact-100 rule explicitly (safety net)
                if (pos > 100) pos = before;

                // Per-turn report (UC6 requirement)
                Console.WriteLine(
                    $"Turn {diceRolls}: Dice={dice}, Option={optionText}, Position: {before} -> {pos}"
                );
            }

            // Final summary (UC6 requirement)
            Console.WriteLine($"\n🎉 Player reached EXACTLY 100!");
            Console.WriteLine($"Total dice rolls to win: {diceRolls}");
        }
    }
}
