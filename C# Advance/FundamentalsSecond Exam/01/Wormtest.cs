using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Wormtest
    {
        static void Main(string[] args)
        {

            var length = long.Parse(Console.ReadLine());
            var width = decimal.Parse(Console.ReadLine());
            length = length * 100;

            if (width == 0)
            {
                Console.WriteLine("{0:f2}", width);

            }
            else
            {
                var remainder = length % width;

                if (remainder == 0)
                {
                    Console.WriteLine("{0:f2}", length * width);
                }
                else
                {
                    var sum = (length / width) * 100;
                    Console.WriteLine("{0:f2}%", sum);
                }
            }
           

        }
    }
}
