using System;
using System.Collections.Generic;
using System.Linq;
using MordorsCrueltyPlan.FoodModels;

namespace MordorsCrueltyPlan
{
   public class StartUp
    {
        public static void Main()
        {
            var listOfFood = new List<Food>();

            var foodList = Console.ReadLine()
                .Split(new[] { ' ', '\t', ';', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var food in foodList)
            {
                listOfFood.Add(FoodFactory.Create(food));
            }
            var sum = listOfFood.Sum(food => food.FoodPoints);
            Console.WriteLine(sum);
            Console.WriteLine(MoodFactory.CreateMood(sum).GetType().Name);
        }
    }
}
