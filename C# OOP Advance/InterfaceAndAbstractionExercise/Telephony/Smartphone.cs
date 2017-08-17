using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class Smartphone : IPhone, IWeb
    {
        public void Call(string[] input)
        {
            foreach (var item in input)
            {
                if (!item.Any(char.IsDigit))
                {
                    Console.WriteLine("Invalid number!");
                }
                else
                {
                    Console.WriteLine($"Calling... {item}");
                }
            }
        }

        public void Browse(string[] input)
        {
            foreach (var item in input)
            {
                if (item.Any(char.IsDigit))
                {
                    Console.WriteLine("Invalid URL!");
                }
                else
                {
                    Console.WriteLine($"Browsing: {item}!");
                }
            }
        }
    }
}
