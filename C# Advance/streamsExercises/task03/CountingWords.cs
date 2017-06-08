
using System.Collections.Generic;
using System.Linq;

namespace task03
{
    using System;
    using System.IO;
   public class CountingWords
    {
       public static void Main()
        {
            var dict = new Dictionary<string, int>();
            var separators = new char[]{ ' ', '-', '.', ',', '?', '!' };

            using (var line = new StreamReader("../../Words.txt"))
            {
                var word = line.ReadLine().ToLower();
                while (word != null)
                {
                    word = word.ToLower();
                    if (!dict.ContainsKey(word))
                    {
                        dict[word] = 0;
                    }
                    word = line.ReadLine();

                }

            }
            using (var line = new StreamReader("../../Text.txt"))
            {
                using (var write = new StreamWriter("../../Result.txt"))
                {
                    var input = line.ReadLine();
                    while (input != null)
                    {
                        var Elements = input.Split(separators, StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();
                            

                        for (int i = 0; i < Elements.Length; i++)
                        {
                            Elements[i] = Elements[i].ToLower();
                            if (dict.ContainsKey(Elements[i]))
                            {
                                dict[Elements[i]]++;
                            }
                        }
                        input = line.ReadLine();
                    }
                    foreach (var kvp in dict.OrderByDescending(x => x.Value))
                    {
                        write.WriteLine($"{kvp.Key} - {kvp.Value}");
                    }
                }
            }
        }
    }
}
