
namespace task10
{
    using System;
    using System.Linq;
    public class UnicodeCharacters
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var result = input.Select(t => string.Format("\\u{0:X4}", Convert.ToUInt16(t))).ToList();
            Console.WriteLine(string.Join("", result).ToLower());
        }
    }
}
