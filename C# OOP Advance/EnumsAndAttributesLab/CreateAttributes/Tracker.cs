
using System;
using System.Linq;
using System.Reflection;
using CreateAttributes;

public class Tracker 
{
    public void PrintMethodsByAuthor()
    {
        var tupeOf = typeof(StartUp);
        var methods = tupeOf.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);

        foreach (var methodInfo in methods)
        {
            if (methodInfo.CustomAttributes.Any(n => n.AttributeType == typeof(SoftUniAttribute)))
            {
                var attrs = methodInfo.GetCustomAttributes(false);
                foreach (SoftUniAttribute attr in attrs)
                {
                    Console.WriteLine($"{methodInfo.Name} is whritten by {attr.Name}");
                }
            }
        }
    }
}
