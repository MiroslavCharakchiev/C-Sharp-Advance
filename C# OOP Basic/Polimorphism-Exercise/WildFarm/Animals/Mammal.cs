using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Animals
{
   public abstract class Mammal : Animal
   {
       private string livingRegion;


       public Mammal(string animalType, string animalName, double animalWight, string livingRegion) 
            : base(animalType, animalName, animalWight)
       {
           this.livingRegion = livingRegion;
       }
   }
}
