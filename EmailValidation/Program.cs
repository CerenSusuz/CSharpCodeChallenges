static void ValidateEmail(string email)
{
    char first = email[0];
    string atSymbol = "@";
    string dotCom = ".com";

    if (Char.IsNumber(first) || Char.IsSymbol(first))
    {
        Console.WriteLine("\nSorry, emails can't start with numbers or symbols.");

        return;
    }

    if (!email.Contains(atSymbol))
    {
        Console.WriteLine("\nYou have to include an 'a' character.");

        return;
    }

    if (email.Substring(email.Length - 4) != dotCom)
    {
        Console.WriteLine("\nGotta have a '.com' at the end.");

        return;
    }

    Console.WriteLine("Email is valid");
    return;
}

Console.WriteLine("Enter the email address you'd like to validate:");
string email = Console.ReadLine();

ValidateEmail(email);
Console.ReadKey();