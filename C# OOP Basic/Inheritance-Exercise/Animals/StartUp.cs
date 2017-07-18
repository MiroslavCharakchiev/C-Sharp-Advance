using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class StartUp
    {
       public static void Main()
        {
            var animals = new List<Animal>();
            string animalType;

            while ((animalType = Console.ReadLine()) != "Beast!")
            {
                var currentAnimalTokens = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    switch (animalType.Trim())
                    {
                        case "Cat":
                            animals.Add(new Cat(currentAnimalTokens[0], int.Parse(currentAnimalTokens[1]), currentAnimalTokens[2]));
                            break;
                        case "Dog":
                            animals.Add(new Dog(currentAnimalTokens[0], int.Parse(currentAnimalTokens[1]), currentAnimalTokens[2]));
                            break;
                        case "Frog":
                            animals.Add(new Frog(currentAnimalTokens[0], int.Parse(currentAnimalTokens[1]), currentAnimalTokens[2]));
                            break;
                        case "Kitten":
                            animals.Add(new Kitten(currentAnimalTokens[0], int.Parse(currentAnimalTokens[1])));
                            break;
                        case "Tomcat":
                            animals.Add(new Tomcat(currentAnimalTokens[0], int.Parse(currentAnimalTokens[1])));
                            break;
                        default:
                            Console.WriteLine("Invalid input!");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message); ;
                }
            }

            foreach (var creature in animals)
            {
                Console.WriteLine(creature.GetType().Name);
                Console.WriteLine(creature);
                creature.ProduceSound();
            }
        }
    }
}
