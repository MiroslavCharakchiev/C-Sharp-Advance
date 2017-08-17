using System.Reflection;

namespace _01HarestingFields
{
    using System;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            var classtype = typeof(HarvestingFields);

            FieldInfo[] privateFields = classtype.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            TakeAccessModifier(privateFields);

        }

        private static void TakeAccessModifier(FieldInfo[] privateFields)
        {
            string input;

            while ((input = Console.ReadLine()) != "HARVEST")
            {
                switch (input)
                {
                    case "private":
                        foreach (var field in privateFields)
                        {
                            if (field.IsPrivate)
                            {
                                PrintFild(field);
                            }
                        }
                        break;
                    case "protected":
                        foreach (var field in privateFields)
                        {
                            if (field.IsFamily)
                            {
                                PrintFild(field);
                            }
                        }
                        break;
                    case "public":
                        foreach (var field in privateFields)
                        {
                            if (field.IsPublic)
                            {
                                PrintFild(field);
                            }
                        }
                        break;
                    case "all":
                        foreach (var field in privateFields)
                        {
                            PrintFild(field);
                        }
                        break;
                }
            }
        }

        private static void PrintFild(FieldInfo field)
        {
            if (field.IsFamily)
            {
                Console.WriteLine($"{"protected"} {field.FieldType.Name} {field.Name}");
            }
            else
            {
                Console.WriteLine($"{field.Attributes.ToString().ToLower()} {field.FieldType.Name} {field.Name}");
            }
        }
    }
}
