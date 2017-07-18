using System.Collections.Generic;
using System.Linq;
using MordorsCrueltyPlan.FoodModels;
using MordorsCrueltyPlan.MoodModels;

namespace MordorsCrueltyPlan
{
   public class MoodFactory
    {
        public static Mood CreateMood(int sum)
        {

            if (sum < -5)
            {
                return new Angry();
            }
            if ( sum <= 0)
            {
                return new Sad();
            }
            if (sum <= 15)
            {
                return new Happy();
            }
                return new JavaScript();
        }
    }
}
