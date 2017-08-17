using System;

namespace StrategyPattern
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }

        public int CompareTo(Person other)
        {
            var result = this.Name.CompareTo(other.Name);
            if (result == 0)
            {
                result = this.Age.CompareTo(other.Age);
            }
            return result;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            var second = obj as Person;

            return this.Name == second.Name && this.Age == second.Age;

        }

        public override int GetHashCode()
        {
            return this.Name.Length * this.Age;
        }
    }

    
}