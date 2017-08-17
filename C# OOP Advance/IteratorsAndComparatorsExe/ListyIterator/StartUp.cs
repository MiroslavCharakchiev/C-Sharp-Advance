using System;
using System.Linq;

namespace ListyIterator
{
    public class StartUp
    {
        public static void Main()
        {
            var createList = Console.ReadLine().Split().Skip(1).ToArray();
            var elements = createList;

            var list = new ListyIterator<string>(createList);
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var tokens = input.Split().ToList();
                var command = tokens[0];
                tokens.RemoveAt(0);
                switch (command)
                {
                    case "Move":
                        Console.WriteLine(list.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(list.HasNext());
                        break;
                    case "Print":
                        list.Print();
                        break;
                    case "PrintAll":
                        PrintAll(list);
                        break;
                }
            }
        }
        public static void PrintAll(ListyIterator<string> list)
        {
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
