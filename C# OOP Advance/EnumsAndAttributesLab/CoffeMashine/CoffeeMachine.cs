
using System;
using System.Collections.Generic;

public class CoffeeMachine
{
    private IList<CoffeeType> coffeeSold;
    private int money;

    public CoffeeMachine()
    {
        this.coffeeSold = new List<CoffeeType>();
        this.money = 0;
    }

    public IEnumerable<CoffeeType> CoffeesSold { get { return this.coffeeSold; } }

    public void BuyCoffee(string size, string type)
    {
        CoffeeType coffeType = (CoffeeType) Enum.Parse(typeof(CoffeeType), type);
        CoffeePrice coffePrice = (CoffeePrice) Enum.Parse(typeof(CoffeePrice), size);
        var Price = (int)coffePrice;

        if (Price <= this.money)
        {
            this.coffeeSold.Add(coffeType);
            this.money = 0;
        }
    }

    public void InsertCoin(string coin)
    {
        var coinGiven = (Coin) Enum.Parse(typeof(Coin), coin);

        this.money += (int)coinGiven;
    }

}