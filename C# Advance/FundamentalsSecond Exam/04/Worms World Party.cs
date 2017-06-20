using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            var worms = new Dictionary<string, Dictionary<string, int>>();

            var wormScore = new Dictionary<string, List<int>>();

            while (true)
            {
                var input = Console.ReadLine().Split(new[] { "-", ">" }, StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "quit")
                {
                    break;
                }

                var player = input[0].Trim();
                var team = input[1].Trim();
                var power = int.Parse(input[2]);

                foreach (var pair in worms)
                {
                    if (worms.ContainsValu)
                    {
                        continue;
                    }

                    if (!worms.ContainsKey(team))
                    {
                        worms[team] = new Dictionary<string, int>();
                    }

                    foreach (var item in worms)
                    {
                       
                        if (item.Key == team)
                        {
                            if (!item.Value.ContainsKey(player))
                            {
                                item.Value.Add(player, power);
                            }
                        }
                    }
                }
            }
            var number = 1;
            foreach (var teamMates in worms.OrderByDescending(c => c.Value.Sum(v => v.Value)).ThenBy(x => x.Value.Count))
            {
                Console.WriteLine($"{number++}. Team: {teamMates.Key} - {teamMates.Value.Sum(v => v.Value)}");
                if (teamMates.Key == teamMates.Key)
                {
                    foreach (var kvp in teamMates.Value.OrderByDescending(v => v.Value))
                    {
                        Console.WriteLine($"###{kvp.Key} : {kvp.Value}");
                    }
                }
            }
        }
    }
}
