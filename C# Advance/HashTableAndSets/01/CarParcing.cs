
namespace _01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CarParcing
    {
        public static void Main(string[] args)
        {
            var parking = new SortedSet<string>();
            while (true)
            {
                var input = Console.ReadLine()
                    .Split(new [] {',', ' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (input[0] == "END")
                {
                    break;
                }

                var comand = input[0];
                var number = input[1];

                if (comand == "IN")
                {
                    parking.Add(number);
                }
                else
                {
                    parking.Remove(number);
                }
            }
            if (parking.Any())
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
