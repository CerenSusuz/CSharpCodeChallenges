Console.WriteLine("How old are you?");
int input = int.Parse(s: Console.ReadLine());

int presidents = CalculatePresidents(input);
Console.WriteLine($"You've voted for {presidents} presidents!");
Console.ReadKey();

static int CalculatePresidents(int age)
{
    int eligibleYears = age - 18;
    int presindents = 0;

    if (eligibleYears <= 0)
    {
        Console.WriteLine("Looks like you are NOT old enough to vote yet.");

        return 0;
    }

    for (int i = 1; i <= eligibleYears; i++)
    {
        if (i % 4 == 0)
        {
            presindents++;
        }
    }

    return presindents;
}