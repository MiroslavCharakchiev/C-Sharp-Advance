
using System;

public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private double selary;

    public Person(string firstName, string lastName, int age, double selary)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.Selary = selary;
    }

   

    public string FirstName {

        get { return this.firstName; }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("First name cannot be less than 3 symbols");
            }
            this.firstName = value;
        }

    }
    public string LastName
    {
        get { return this.lastName; }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Last name cannot be less than 3 symbols");
            }
            this.lastName = value;
        }
    }

    public int Age
    {
        get { return this.age; }
        set
        {
            if (value < 1)
            {
                throw new ArgumentException("Age cannot be zero or negative integer");
            }
            this.age = value;
        }
    }

    public double Selary
    {
        get { return this.selary; }
        set
        {
            if (value < 460.00)
            {
                throw new ArgumentException("Salary cannot be less than 460 leva");
            }
            this.selary = value;
        }
    }

    public void IncreaseSalary(double bonus)
    {
        if (this.age > 30)
        {
            this.selary += this.selary * (bonus / 100);
        }
        else
        {
            this.selary += this.selary * (bonus / 200);
        }
    }
    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} get {this.Selary:f2} leva";
    }
   
}
