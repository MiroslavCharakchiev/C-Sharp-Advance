
using System.Collections.Generic;
using System.Linq;

public class Person
{
    private string name;
    private int age;
    private List<BankAccount> accounts;

    public Person()
    {
        this.name = "Name";
        this.age = 0;
        this.accounts = new List<BankAccount>();
    }
    public Person(int age) : this()
    {
        this.age = age;
        
    }
    public Person (string name, int age) : this(age)
        
    {
        this.name = name;
        
    }

    public Person(string name, int age, List<BankAccount> acc) : this(name, age)
    {
        
        this.accounts = acc;
    }

   

    public double GetBalance()
    {
        return this.accounts.Sum(x => x.Balance);
    }
}
