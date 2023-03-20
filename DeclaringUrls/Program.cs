static string[] BreakdownURL(string url)
{
    string[] components =
        url.Remove(0, 4) //no www.
           .Replace("-", " ") //no dashes
           .Split('/');

    return components;
}

Console.WriteLine("Here you can enter the url for declaring:");
string url = Console.ReadLine();

var components = BreakdownURL(url);

for (int i = 0; i < components.Length; i++)
{
    var indent = new string(' ', i * 2);
    Console.WriteLine($"{indent} -> {components[i]}");
}