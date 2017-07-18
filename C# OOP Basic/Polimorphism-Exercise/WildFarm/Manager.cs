using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Animals;

namespace WildFarm
{
   public class Manager
    {
        public void Run()
        {
            string animal;
            while ((animal = Console.ReadLine()) == "End")
            {
                var tokens = animal.Split().ToArray();
                var type = tokens[0];
                var name = tokens[1];
                var wight = int.Parse(tokens[2]);
                var region = tokens[3];

                switch (type)
                {
                    case "Cat":
                        var cat = new Cat(type, name, wight, region, tokens[4]);
                        break;
                    case "Tiger":
                        var tiger = new Tiger(type, name, wight, region);
                        break;
                    case "Cat":
                        var cat = new Cat(type, name, wight, region, tokens[4]);
                        break;
                    case "Cat":
                        var cat = new Cat(type, name, wight, region, tokens[4]);
                        break;
                }

            }
        }
    }
}
