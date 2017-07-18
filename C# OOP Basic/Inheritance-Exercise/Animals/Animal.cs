using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.name = name;
            this.Age = age;
            this.gender = gender;
        }

        protected int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.age = value;
            }
        }

        public abstract void ProduceSound();

        public override string ToString()
        {
            return $"{this.name} {this.Age} {this.gender}";
        }
    }
}
