class MainClass
{
    public static Dictionary<char, int> vowelScores = new()
        {
            { 'a', 1 },
            { 'e', 2 },
            { 'i', 3 },
            { 'o', 4 },
            { 'u', 5 },
            { 'y', 9 }
        };

    public static void Main(string[] args)
    {
        Console.WriteLine("Type in a word or phrase to find it's vowel score:");

        string input = Console.ReadLine().ToLower();
        Console.WriteLine($"Score: {VowelCount(input)}");
        Console.ReadKey();
    }

    public static int VowelCount(string text)
    {
        int totalScore = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (vowelScores.TryGetValue(text[i], out int points))
            {
                totalScore += points;
            }
        }

        return totalScore;
    }
}