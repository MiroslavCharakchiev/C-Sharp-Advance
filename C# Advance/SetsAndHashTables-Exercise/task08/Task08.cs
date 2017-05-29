
namespace task08
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Task08
    {
        public static void Main()
        {
            var cardPowers = GetCardPower();
            var cardTypes = GetCardType();
           var poker = new Dictionary<string,HashSet<int>>();

            while (true)
            {
                var readLine = Console.ReadLine();
                if (readLine != null)
                {
                    var input = readLine
                        .Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    if (input[0] == "JOKER")
                    {
                        break;
                    }
                    for (int i = 1; i < input.Length; i++)
                    {
                        var cardPower = input[i].Substring(0, input[i].Length - 1);
                        var cardType = input[i].Substring(input[i].Length - 1);

                        var sum = cardPowers[cardPower] * cardTypes[cardType];

                        if (!poker.ContainsKey(input[0]))
                        {
                            poker[input[0]] = new HashSet<int>();
                        }

                        poker[input[0]].Add(sum);
                    }
                }
            }
            foreach (var player in poker)
            {
                Console.WriteLine($"{player.Key} {player.Value.Sum()}");
            }
        }

        private static Dictionary<string, int> GetCardType()
        {
            var type = new Dictionary<string, int>
            {
                ["S"] = 4,
                ["H"] = 3,
                ["D"] = 2,
                ["C"] = 1
            };

            return type;
        }

        private static Dictionary<string, int> GetCardPower()
        {
            var power = new Dictionary<string, int>();

            for (int i = 2; i <= 10; i++)
            {
                power[i.ToString()] = i;
            }
            power["J"] = 11;
            power["Q"] = 12;
            power["K"] = 13;
            power["A"] = 14;

            return power;
        }
    }
}
