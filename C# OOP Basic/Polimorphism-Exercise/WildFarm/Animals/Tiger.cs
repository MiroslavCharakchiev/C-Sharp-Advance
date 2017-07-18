using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Animals
{
    public class Tiger : Felime
    {
        public Tiger(string animalType, string animalName, double animalWight, string livingRegion) 
            : base(animalType, animalName, animalWight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }

        public override void Eat()
        {
            throw new NotImplementedException();
        }

       
    }
}
