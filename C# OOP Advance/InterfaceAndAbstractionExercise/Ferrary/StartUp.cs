using System;

namespace Ferrary
{
   public class StartUp
    {
        public static void Main()
        {
            string ferrariName = typeof(Ferrari).Name;
            string iCarInterfaceName = typeof(ICar).Name;
            var input = Console.ReadLine();
            bool isCreated = typeof(ICar).IsInterface;
            if (!isCreated)
            {
                throw new Exception("No interface ICar was created");
            }
            else
            {
                ICar car = new Ferrari(input);
                Console.Write($"{car.Model}/");
                car.Break();
                Console.Write("/");
                car.Gas();
                Console.Write("/");
                Console.WriteLine($"{car.DriverName}");
            }

        }
    }
}
