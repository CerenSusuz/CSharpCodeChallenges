using System.Timers;

namespace affirmingwords
{
    class MainClass
    {
        static readonly Random random = new();
        static readonly List<string> encouragements = new()
        {
            "Way to go!",
            "Keep it up!",
            "Almost there!",
            "You're doing great!"
        };

        static System.Timers.Timer timer;

        public static void Main(string[] args)
        {
            Console.WriteLine("Hit ENTER to start the timer!");
            Console.ReadLine();

            StartTimer(3);

            Console.WriteLine("You can end the timer anytime by pressing ENTER.\n");
            Console.ReadLine();
            StopTimer();
        }

        public static void StartTimer(int interval)
        {
            int milliseconds = interval * 1000;
            timer = new System.Timers.Timer(milliseconds);

            timer.Elapsed += OnTimerEvent;

            timer.AutoReset = true;
            timer.Enabled = true;
        }

        private static void OnTimerEvent(Object source, ElapsedEventArgs e)
        {
            int index = random.Next(4);
            Console.WriteLine(encouragements[index]);
        }

        public static void StopTimer()
        {
            timer.Stop();
            timer.Dispose();
            Console.WriteLine("Time stopped");
        }
    }
}