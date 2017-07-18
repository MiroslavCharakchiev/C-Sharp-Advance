using System.Collections.Generic;
using System.Linq;

namespace CreatingConstructors
{
   public class Family
   {
       private List<Person> family;

       public Family()
       {
           this.family = new List<Person>();
       }

       public void AddMember(Person member)
       {
           family.Add(member);
       }

       public List<Person> GetMembersByAge()
       {
           return this.family.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();
       }
   }
}
