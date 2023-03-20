static void PrintStats(List<int> scores)
{
    scores.Sort();

    int lowest = scores[0];
    Console.WriteLine($"\nLowest scoring game: \t-> {lowest}");

    int highest = scores[scores.Count - 1];
    Console.WriteLine($"Highest scoring game: \t-> {highest}");

    int sum = 0;
    for (int i = 0; i < scores.Count; i++)
    {
        sum += scores[i];
    }

    Console.WriteLine($"Total season points \t-> {sum}");
    Console.WriteLine($"Average points/game \t-> {sum / scores.Count}");
}

List<int> scores = new List<int>();

for (int i = 1; i < 4; i++)
{
    Console.WriteLine($"How many points did you score in game #{i}?");
    int input = int.Parse( Console.ReadLine());
    scores.Add(input);
}

PrintStats(scores);
Console.ReadKey();