
namespace _10
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Problem10
    {
       public static void Main(string[] args)
       {
           var number = int.Parse(Console.ReadLine());
            var queue = new Queue<char>();
            var reserveQueue = new Queue<char>();
           for (int i = 0; i < number; i++)
           {
               var input = Console.ReadLine().Split().ToArray();
               if (input[0] == "1")
               {
                   var temp = input[1];
                   for (int j = 0; j < temp.Length; j++)
                   {
                   queue.Enqueue(temp[j]);
                   }
               }
               else if (input[0] == "2")
               {
                   var temp = int.Parse(input[1]);

                   for (int j = 0; j < temp; j++)
                   {
                       reserveQueue.Enqueue(queue.Dequeue());
                   }
               }
                  
           }

       }
    }
}
