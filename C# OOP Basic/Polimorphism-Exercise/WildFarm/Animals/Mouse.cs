using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Animals
{
    public class Mouse : Mammal
    {
       

        public override void MakeSound()
        {
            Console.WriteLine("SQUEEEAAAK!");
        }

        public override void Eat()
        {
            throw new NotImplementedException();
        }


        public Mouse(string animalType, string animalName, double animalWight, string livingRegion) 
            : base(animalType, animalName, animalWight, livingRegion)
        {
        }
    }
}
