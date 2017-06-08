
namespace task01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;


   public class StreamsReading
    {
        public static void Main()
        {
            using (var reader = new StreamReader("../../ReadFile.txt"))
            {
                var line = reader.ReadLine();
                var count = 1;
                while (line != null)
                {
                    if (count % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }

                    line = reader.ReadLine();
                    count++;
                }
            }
        }
    }
}
