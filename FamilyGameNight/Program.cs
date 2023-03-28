namespace FamilyGameNight
{
    class MainClass
    {
        public static List<Player> players = new()
        {
            new Player("Douglas", "Flores", 233, 198),
            new Player("Kathryn", "Flores", 219, 202),
            new Player("Robin", "Flores", 241, 222),
            new Player("James", "Ortiz", 144, 198),
            new Player("Sharon", "Ortiz", 233, 198),
            new Player("Jack", "Wagner", 189, 234),
            new Player("Amanda", "Wagner", 211, 178)
        };

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter an improvement index to see which game night attendees fit the bill:");
            var targetImprovement = int.Parse(Console.ReadLine());

            PrintStats(targetImprovement);
            Console.ReadKey();
        }

        public static void PrintStats(int targetImprovement)
        {
            var gameQuery =
                from player in players

                let improvement = player.currentScore - player.lastScore
           
                where improvement > targetImprovement && improvement > 0
           
                group player by player.lastname[0] into playerGroup
         
                orderby playerGroup.Key
               
                select playerGroup;

            foreach (var playerGroup in gameQuery)
            {
                Console.WriteLine("\n" + playerGroup.Key);
                foreach (var player in playerGroup)
                {
                    Console.WriteLine($"{player.firstname} {player.lastname} improved by more than {targetImprovement}!");
                }
            }
        }
    }
}