using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Animals
{
    public abstract class Animal
    {
        private string animalType;
        private string animalName;
        private double animalWight;
        private int foodEaten;

        protected Animal(string animalType, string animalName, double animalWight)
        {
            this.animalType = animalType;
            this.animalName = animalName;
            this.animalWight = animalWight;
            this.foodEaten = 0;
        }

        public abstract void MakeSound();
        public abstract void Eat();
    }
}
