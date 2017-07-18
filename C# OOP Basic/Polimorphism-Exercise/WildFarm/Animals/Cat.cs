using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Animals
{
    public class Cat : Felime
    {
        private string breed;

        public Cat(string animalType, string animalName, double animalWight, string livingRegion, string breed) 
            : base(animalType, animalName, animalWight, livingRegion)
        {
            this.breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }

        public override void Eat()
        {
            throw new NotImplementedException();
        }

       
    }
}
