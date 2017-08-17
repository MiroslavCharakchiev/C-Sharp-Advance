using System.Linq;
using System.Reflection;

namespace _02BlackBoxInteger
{
    using System;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            Type bbType = typeof(BlackBoxInt);

            ConstructorInfo ctor = bbType.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, Type.DefaultBinder, new Type[] { }, null);
            var instance = ctor.Invoke(new object[0]);



            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var tokens = input.Split('_');
                var command = tokens[0];
                var number = int.Parse(tokens[1]);

               bbType.GetMethod(command, BindingFlags.NonPublic | BindingFlags.Instance).Invoke(instance, new object[]{number});

                object result = bbType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).First()
                    .GetValue(instance);
                Console.WriteLine(result);
            }
        }
    }
}
