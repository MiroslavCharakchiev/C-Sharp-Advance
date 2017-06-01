namespace tack05
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
   public class task05
    {
       public static void Main(string[] args)
        {
            var Phonebook = new Dictionary<string, string>();

            while (true)
            {
                var input = Console.ReadLine().Split('-').ToArray();
                if (input[0] == "search")
                {
                    break;
                }
                if (!Phonebook.ContainsKey(input[0]))
                {
                    Phonebook[input[0]] = input[1];
                }
                else
                {
                    Phonebook[input[0]] = input[1];
                }
            }
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                if (Phonebook.ContainsKey(input))
                {
                    foreach (var kvp in Phonebook)
                    {
                        if (kvp.Key == input)
                        {
                            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                        }
                    }
                    
                }
                else
                {
                    Console.WriteLine($"Contact {input} does not exist.");
                }
            }
        }
    }
}
