
public class Animal
{
    private string name;
    private string favouriteFood;

    public string FavouriteFood
    {
        get { return this.favouriteFood; }
        set { this.favouriteFood = value; }
    }


    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public virtual string ExplainMyself()
    {
        return $"I am {this.Name} and my favorite food is {this.FavouriteFood}";
    }

}
