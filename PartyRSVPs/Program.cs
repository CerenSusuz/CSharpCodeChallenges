namespace partyrsvp
{
    class MainClass
    {
        static List<string> family = new() { "Harrison", "Kelsey", "Alex", "Haley" };
        static List<string> friends = new() { "James", "Hannah", "Kelly", "Alex" };
        static List<string> rsvp = new() { "Kelly", "Harrison" };

        public static void Main(string[] args)
        {
            Console.WriteLine("Hit ENTER to see your party invite breakdown!");
            Console.ReadKey();

            InviteDetails();
            Console.ReadKey();
        }

        public static void InviteDetails()
        {
            HashSet<string> everyone = new HashSet<string>(family);
            everyone.UnionWith(friends);
            Console.WriteLine($"You sent out {everyone.Count} invites total!\n");
            Console.WriteLine($"Duplicates sent to:");
            HashSet<string> duplicates = new(family); 
            duplicates.IntersectWith(friends);
            PrintSets(duplicates);
            Console.WriteLine("People who haven't responded yet:");
            everyone.SymmetricExceptWith(rsvp);
            PrintSets(everyone);
        }

        public static void PrintSets(HashSet<string> names)
        {
            foreach (string name in names)
            {
                Console.WriteLine($"  -> {name}");
            }
            Console.WriteLine();
        }
    }
}