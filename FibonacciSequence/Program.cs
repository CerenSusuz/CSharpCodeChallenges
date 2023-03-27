namespace fibsequence
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Fibonacci elements you'd like to calculate:");
            int input = int.Parse(Console.ReadLine());

            var sequence = CalculateFibonacci(input);
            foreach (var fibonacci in sequence)
            {
                Console.WriteLine(fibonacci);
            }

            Console.ReadKey();
        }

        public static List<int> CalculateFibonacci(int length)
        {
            List<int> sequence = new();
            int firstNumber = 0, secondNumber = 1;

            sequence.Add(firstNumber);
            sequence.Add(secondNumber);

            for (int i = 2; i < length; i++)
            {
                int nextNumber = firstNumber + secondNumber;
                sequence.Add(nextNumber);
                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }

            return sequence;
        }
    }
}