namespace shopinventory
{
    class MainClass
    {
        static Shop shop = new();

        public static void Main(string[] args)
        {
            Console.WriteLine("Add your inventory items:");

            for (int index = 0; index < 3; index++)
            {
                var item = Console.ReadLine();
                AddItem(index, item);
            }

            Console.WriteLine("Retrieve all stored items:");
            GetAllItems();
        }

        public static void AddItem(int index, string name)
        {
            try
            {
                shop[index] = name;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void GetAllItems()
        {
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    Console.WriteLine(shop[i]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}