
namespace task09
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Task09
    {
        public static void Main()
        {
            var container = new SortedDictionary<string, Dictionary<string,int>>();

            while (true)
            {
                var input = Console.ReadLine().Split(" =".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "end")
                {
                    break;
                }
                var ip = input[1];
                var name = input[5];

                if (!container.ContainsKey(name))
                {
                    container[input[5]] = new Dictionary<string, int>();
                }

                foreach (var kvp in container)
                {
                    if (!kvp.Value.ContainsKey(ip))
                    {
                        kvp.Value.Add(ip, 1);
                    }
                    else
                    {
                        
                    }
                }

            }
        }
    }
}
