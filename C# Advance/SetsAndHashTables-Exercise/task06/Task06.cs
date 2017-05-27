

namespace task06
{
    using System;
    using System.Collections.Generic;
    public class Task06
    {
       public static void Main(string[] args)
        {
            var container = new Dictionary<string, int>();
            var material = string.Empty;
            var count = 1;

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }
                if (count % 2 == 0)
                {
                    container[material] += int.Parse(input);
                }
                else
                {
                    material = input;
                    if (!container.ContainsKey(material))
                    {
                        container[material] = 0;
                    }
                }
                count++;
            }
            foreach (var kvp in container)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
