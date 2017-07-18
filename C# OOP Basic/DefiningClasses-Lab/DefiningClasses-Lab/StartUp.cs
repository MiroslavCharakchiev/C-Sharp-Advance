
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;

public class StartUp
{
    public static void Main()
    {
        var acc = new Dictionary<int, BankAccount>();
        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var cmdArgs = input.Split();
            var comand = cmdArgs[0];
            switch (comand)
            {
                case "Create":
                    Create(cmdArgs, acc);
                    break;
                case "Deposit":
                    Deposit(cmdArgs, acc);
                    break;
                case "Withdraw":
                    Withdraw(cmdArgs, acc);
                    break;
                case "Print":
                    Print(cmdArgs, acc);
                    break;
            }
        }
       
        

    }

    private static void Print(string[] cmdArgs, Dictionary<int, BankAccount> acc)
    {
        var id = int.Parse(cmdArgs[1]);
        if (acc.ContainsKey(id))
        {
            foreach (var bankAccount in acc)
            {
                if (bankAccount.Key == id)
                {
                    Console.WriteLine($"Account ID{bankAccount.Key}, balance {bankAccount.Value.Balance:f2}");
                }
            }
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void Withdraw(string[] cmdArgs, Dictionary<int, BankAccount> acc)
    {
        var id = int.Parse(cmdArgs[1]);
        var amount = double.Parse(cmdArgs[2]);
        if (acc.ContainsKey(id))
        {
            if (acc[id].Balance - amount >= 0)
            {
                acc[id].Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void Deposit(string[] cmdArgs, Dictionary<int, BankAccount> acc)
    {
        var id = int.Parse(cmdArgs[1]);
        var amount = double.Parse(cmdArgs[2]);
        if (acc.ContainsKey(id))
        {
            acc[id].Balance += amount;
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void Create(string[] cmdArgs, Dictionary<int, BankAccount> acc)
    {
        var id = int.Parse(cmdArgs[1]);
        if (acc.ContainsKey(id))
        {
            Console.WriteLine("Account already exists");
        }
        else
        {
            var account = new BankAccount();
            account.ID = id;
            acc.Add(id, account);
        }
    }
}
