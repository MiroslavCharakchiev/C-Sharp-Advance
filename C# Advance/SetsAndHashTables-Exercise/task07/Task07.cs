
namespace task07
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Task07
    {
        public static void Main()
        {
            var mail = new Dictionary<string,string>();
            var count = 1;
            var name = string.Empty;
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }

                if (!(count % 2 == 0))
                {
                    name = input;
                    mail[name] = string.Empty;
                }
                else
                {
                    mail[name] = input;
                }
                count++;
            }
            foreach (var contact in mail)
            {
                if (!contact.Value.EndsWith(".eu") && !contact.Value.EndsWith(".us"))
                {
                    Console.WriteLine($"{contact.Key} -> {contact.Value}");
                }
            }
        }
    }
}
