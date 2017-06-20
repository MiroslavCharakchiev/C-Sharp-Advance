using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine().Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "Worm Ipsum")
                {
                    break;
                }
                if (input.Length == 1)
                {
                    var words = input[0].Split(/*new[] { " " }, StringSplitOptions.RemoveEmptyEntries*/).ToList();
                    charCounter(words);
                }
            }
        }

        private static void charCounter(List<string> words)
        {

            for (int j = 0; j < words.Count; j++)
           {
                char[] cArray = words[j].ToCharArray();
                var dict = new Dictionary<char, int>();

                for (int i = 0; i < cArray.Length; i++)
                {
                    if (!dict.ContainsKey(cArray[i]))
                    {
                        dict[cArray[i]] = 1;
                    }
                    else
                    {
                        dict[cArray[i]]++;
                    }
                }
                foreach (var letter in dict.OrderByDescending(l => l.Value))
                {
                    if (letter.Value >= 2)
                    {
                        for (int i = 0; i < cArray.Length; i++)
                        {
                            if ((int)cArray[i] >= 65 && (int)cArray[i] <= 122 || (int)cArray[i] >= 48 && (int)cArray[i] <= 57)
                            {
                                cArray[i] = letter.Key;
                            }
                        }
                        var str = string.Empty;
                        for (int i = 0; i < cArray.Length; i++)
                        {
                            str += cArray[i];
                        }
                        words[j] = str;
                    }
                    break;
                }
            }
            Console.WriteLine(string.Join (" ", words) +".");
        }
    }
}
