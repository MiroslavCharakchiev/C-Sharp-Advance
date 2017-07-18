using System;
using System.Globalization;

namespace OpinionPoll
{
   public class DateModifier
   {
       private DateTime firsdate;
       private DateTime seconddate;

       public DateModifier(string first, string second)
       {
           
           this.firsdate = DateTime.ParseExact(first, "yyyy MM dd", CultureInfo.InvariantCulture);
           this.seconddate = DateTime.ParseExact(second, "yyyy MM dd", CultureInfo.InvariantCulture);
       }

       public double DateDiference()
       {
           var diference = this.firsdate - this.seconddate;
           return Math.Abs(diference.TotalDays);
       }
   }
}
