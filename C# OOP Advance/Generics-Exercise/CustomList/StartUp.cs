using System;
using System.Linq;

namespace CustomList
{
    public class StartUp
    {
        public static void Main()
        {
            CustomList<String> list = new CustomList<string>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var tokens = input.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
                var command = tokens[0];

                switch (command)
                {
                    case "Add":
                        list.Add(tokens[1]);
                        break;
                    case "Remove":
                        list.Remove(int.Parse(tokens[1]));
                        break;
                    case "Contains":
                        Console.WriteLine(list.Contains(tokens[1]));
                        break;
                    case "Swap":
                        list.Swap(int.Parse(tokens[1]), int.Parse(tokens[2]));
                        break;
                    case "Greater":
                        Console.WriteLine(list.CountGreaterThan(tokens[1]));
                        break;
                    case "Max":
                        Console.WriteLine(list.Max());
                        break;
                    case "Min":
                        Console.WriteLine(list.Min());
                        break;
                    case "Sort":
                        list = Sorter.Sort(list);
                        break;
                    case "Print":
                        Print(list);
                        break;
                }
            }
        }

        private static void Print(CustomList<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
