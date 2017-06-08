
namespace task02
{
    using System;
    using  System.IO;
   public  class StreamsWrithing
    {
       public static void Main()
        {
            using (var reader = new StreamReader("../../ReadFile.txt"))
            {

                using (var writer = new StreamWriter("../../Result.txt"))
                {
                    var line = reader.ReadLine();
                    var count = 1;
                    while (line != null)
                    {
                        writer.WriteLine($"{count}.{line}");
                        count++;

                        line = reader.ReadLine();
                    }

                }
            }
        }
    }
}
