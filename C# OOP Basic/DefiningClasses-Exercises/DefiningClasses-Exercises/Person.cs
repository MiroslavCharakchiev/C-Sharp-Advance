﻿
class Person
{
    public string name;
    public int age;

    public Person()
    {
        this.Name = "No name";
        this.Age = 1;
    }

    public Person(int age)
    {
        this.Name = "No name";
        this.Age = age;
    }
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name
    {
        get { return this.Name; }
        set { this.name = value; }
    }

    public int Age
    {
        get{return this.age;}
        set { this.age = value; }
    }
}
