
using System;

namespace CreatingConstructors
{
    public class StartUp
    {
        public static void Main()
        {
            

            var input = int.Parse(Console.ReadLine());
            var family = new Family();

            for (int i = 0; i < input; i++)
            {
                var Tokens = Console.ReadLine().Split();
                var personName = Tokens[0];
                var personAge = int.Parse(Tokens[1]);

                var person = new Person(personName, personAge);

                family.AddMember(person);
            }

            var oldestMembers = family.GetMembersByAge();

            foreach (var person in oldestMembers)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
