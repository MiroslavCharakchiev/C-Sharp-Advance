using BorderControl.Interfaces;

namespace BorderControl
{
    public class Pet : IBirthdate
    {
        public Pet( string name, string birthdate)
        {
            this.Birthdate = birthdate;
            this.Name = name;
        }
        public string Birthdate { get; }
        public string Name { get; }


    }
}
