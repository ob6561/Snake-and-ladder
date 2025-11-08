namespace Snake_and_ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("snake ladder game");
            int pos = 0;
            var rnd = new Random();
            int dice = rnd.Next(1, 7);
            Console.WriteLine("Player rolled dice: " + dice);
            pos += dice;
            Console.WriteLine("Starting position of the player is: " + pos);
        }
    }
}
