using System.Reflection;
using static CarDealership.Factory;

namespace reflection
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hit ENTER to find the vehicles you're looking for!");
            Console.ReadKey();

            var models = GetModels(typeof(Car));
            foreach (var model in models)
            {
                Console.WriteLine(model.Name);
            }

            Console.ReadKey();
        }

        public static List<Type> GetModels(Type abstractClass)
        {
            var allTypes = Assembly.GetAssembly(abstractClass).GetTypes();

            var filteredTypes = allTypes.Where(type =>
                                                    !type.IsAbstract &&
                                                    abstractClass.IsAssignableFrom(type));

            return filteredTypes.ToList();
        }
    }
}