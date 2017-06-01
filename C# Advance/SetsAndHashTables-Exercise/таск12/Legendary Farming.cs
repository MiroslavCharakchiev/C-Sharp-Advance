
namespace таск12
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
       public static void Main()
        {
            string shards = "shards";
            string fragments = "fragments";
            string motes = "motes";

            var materials = new Dictionary<string, int>();

            materials[shards] = 0;
            materials[fragments] = 0;
            materials[motes] = 0;

            bool isWin = true;

            while (isWin)
            {
                string[] line = Console.ReadLine().ToLower().Split(' ');

                for (int i = 0; i < line.Length; i += 2)
                {
                    int mark = int.Parse(line[i]);
                    string material = line[i + 1];

                    if (!materials.ContainsKey(material))
                    {
                        materials.Add(material, 0);
                    }
                    materials[material] += mark;

                    if (materials[shards] >= 250 || materials[fragments] >= 250 || materials[motes] >= 250)
                    {
                        isWin = false;

                        switch (material)
                        {
                            case "shards":
                                Console.WriteLine("Shadowmourne obtained!");
                                materials[material] -= 250;
                                break;
                            case "fragments":
                                Console.WriteLine("Valanyr obtained!");
                                materials[material] -= 250;
                                break;
                            case "motes":
                                Console.WriteLine("Dragonwrath obtained!");
                                materials[material] -= 250;
                                break;
                            default:
                                break;
                        }
                        break;
                    }
                }
            }

            var keyMaterials = materials.Take(3);

            foreach (var material in keyMaterials.OrderByDescending(m => m.Value).ThenBy(m => m.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

            foreach (var material in materials.Skip(3).OrderBy(m => m.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }
    }
}
