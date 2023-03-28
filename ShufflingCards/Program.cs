namespace ShufflingCards
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hit ENTER to shuffle the deck and deal the top 5 cards!");
            Console.ReadKey();

            var freshDeck = new Deck();
            var shuffledDeck = Shuffle(freshDeck.cards);
            Deal(new Stack<string>(shuffledDeck));

            Console.ReadKey();
        }

        public static List<string> Shuffle(List<string> deck)
        {
            Random random = new();

            for (int i = 0; i < deck.Count; i++)
            {
                int randomIndex = random.Next(i, deck.Count);

                (deck[randomIndex], deck[i]) = (deck[i], deck[randomIndex]);
            }

            return deck;
        }

        public static void Deal(Stack<string> shuffledDeck)
        {
            Console.WriteLine("Your hand:");

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"  -> {shuffledDeck.Pop()}");
            }

            Console.WriteLine("\nBurned top card...");
            var burn = shuffledDeck.Pop();

            Console.WriteLine("\nHole cards:");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"  -> {shuffledDeck.Pop()}");
            }

            Console.WriteLine("\nBetting starts!");
        }
    }
}