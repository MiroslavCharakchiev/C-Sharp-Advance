using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
   public class StartUp
    {
       public static void Main()
       {
           var callInput = Console.ReadLine().Split();
           var browseInput = Console.ReadLine().Split();

            var phone = new Smartphone();
            phone.Call(callInput);
            phone.Browse(browseInput);
       }
    }
}
