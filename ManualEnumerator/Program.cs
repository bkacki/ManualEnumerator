namespace ManualEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sports = new ManualSportSequence();
            foreach(var sport in sports)
                Console.WriteLine(sport);

            Console.WriteLine();

            var betterSports = new BetterSportSequence();
            foreach(var sport in betterSports)
                Console.WriteLine(sport);
            Console.WriteLine($"Test indexera betterSports[3] - {betterSports[3]}");
        }
    }
}
