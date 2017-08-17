using System;
using System.Collections.Generic;
using System.Linq;
using BorderControl.Interfaces;

namespace BorderControl
{
    public class StartUp
    {
        public static void Main()
        {
            var list = new List<IBuyer>();
            var lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var line = Console.ReadLine().Split();
                if (line.Length == 4)
                {
                    list.Add(new Citizen(line[0], int.Parse(line[1]), line[2], line[3]));
                }
                else
                {
                    list.Add(new Rebel(line[0], int.Parse(line[1]), line[2]));
                }

            }
            var sum = 0;
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                foreach (var buyer in list)
                {
                    if (buyer.Name == input)
                    {
                        buyer.BuyFood();
                    }
                }
                //var tokens = input.Split().ToList();

                //switch (command)
                //{
                //    case "Citizen":
                //        break;
                //    case "Pet":
                //        list.Add(new Pet(tokens[0], tokens[1]));
                //        break;
                //    case "Robot":
                //        //list.Add(new Robot(tokens[0], tokens[1]));
                //        break;
                //}
               
            }
            //var chek = Console.ReadLine();
            foreach (var popilation in list)
            {
                sum += popilation.Food;
            }
            Console.WriteLine(sum);
        }
    }
}
