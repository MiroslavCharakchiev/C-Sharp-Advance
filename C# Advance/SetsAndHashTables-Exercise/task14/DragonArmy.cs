
namespace task14
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DragonArmy
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var dragonsType = new Dictionary<string, SortedDictionary<string, double[]>>();

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] inputArgs = line.Split(' ');
                string type = inputArgs[0];
                string name = inputArgs[1];
                double damage = 45;
                double health = 250;
                double armor = 10;

                if (inputArgs[2] != "null")
                {
                    damage = double.Parse(inputArgs[2]);
                }

                if (inputArgs[3] != "null")
                {
                    health = double.Parse(inputArgs[3]);
                }

                if (inputArgs[4] != "null")
                {
                    armor = double.Parse(inputArgs[4]);
                }

                if (!dragonsType.ContainsKey(type))
                {
                    dragonsType.Add(type, new SortedDictionary<string, double[]>());
                }

                if (!dragonsType[type].ContainsKey(name))
                {
                    dragonsType[type][name] = new double[3];
                }

                dragonsType[type][name][0] = damage;
                dragonsType[type][name][1] = health;
                dragonsType[type][name][2] = armor;

            }

            foreach (var type in dragonsType)
            {
                Console.WriteLine($"{type.Key}::({type.Value.Select(x => x.Value[0]).Average():F2}/{type.Value.Select(x => x.Value[1]).Average():F2}/{type.Value.Select(x => x.Value[2]).Average():F2})");

                foreach (var name in type.Value)
                {
                    Console.WriteLine($"-{name.Key} -> damage: {name.Value[0]}, health: {name.Value[1]}, armor: {name.Value[2]}");
                }
            }
        }
    }
}
