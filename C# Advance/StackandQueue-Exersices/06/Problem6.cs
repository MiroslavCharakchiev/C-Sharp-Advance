
namespace _06
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Problem6
    {
       public  static void Main(string[] args)
       {
           var number = int.Parse(Console.ReadLine());
            var queue = new Queue<long>();
            var originalQue = new long[number*2] ;
           for (int i = 0; i < number; i++)
           {
               var input = Console.ReadLine().Split().Select(long.Parse).ToArray();

               queue.Enqueue(input[0]);
               queue.Enqueue(input[1]);
               
            }
           
           var temp = false;
            queue.CopyTo(originalQue,0);
            var queue2 = new Queue<long>(originalQue);
           for (int i = 0; i < number; i++)
           {

               var pump = 0L;
               for (int j = 0; j < number; j++)
               {
                   pump +=  queue.Dequeue();
                   var miles = queue.Dequeue();
                   queue.Enqueue(pump);
                   queue.Enqueue(miles);
                   if (pump > miles)
                   {
                       pump -= miles;
                       temp = true;
                   }
                   else
                   {
                       temp = false;
                       break;
                   }
                }

               if (temp == true)
               {
                   Console.WriteLine(i);
                   break;
               }
               queue2.Enqueue(queue2.Dequeue());
               queue2.Enqueue(queue2.Dequeue());
               queue.Clear();
               for (int j = 0; j < queue2.Count; j++)
               {
                   var num1 = queue2.Dequeue();
                    queue2.Enqueue(num1);
                   queue.Enqueue(num1);
                }
            }
        }
    }
}
