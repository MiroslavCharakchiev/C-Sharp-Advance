using BorderControl.Interfaces;

namespace BorderControl
{
   public class Citizen : IBirthdate, IPopilation, IBuyer
    {
        public Citizen( string name, int age, string id, string birthdate)
        {
            this.Birthdate = birthdate;
           this.Id = id;
           this.Name = name;
           this.Age = age;
            this.Food = 0;
        }
        public string Id { get; }

        public  string Name { get; }

        public int Age { get; }
        public string Birthdate { get; }
        public int Food { get; set; }
        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
