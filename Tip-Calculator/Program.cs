namespace tipcalculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the cost of your meal to calculate tip options:");
            var input = int.Parse(Console.ReadLine());

            var (low, mid, high) = CalculateTip(input);
            Console.WriteLine($"\n10% -> ${low} \n17.5% -> ${mid} \n25% -> ${high}");
            Console.ReadKey();
        }

        public static (string low, string mid, string high) CalculateTip(int cost)
        {
            string lowTiper = Math.Round(cost * 0.10, 2).ToString("#.00");
            string mediumTip = Math.Round(cost * 0.175, 2).ToString("#.00");
            string highTipper = Math.Round(cost * 0.25, 2).ToString("#.00");

            return (lowTiper, mediumTip, highTipper);
        }
    }
}