
namespace task01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Task01
    {
        public static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var set = new HashSet<string>();
            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine();

                set.Add(input);
            }
            foreach (var name in set)
            {
                Console.WriteLine(name);
            }
        }
    }
}
