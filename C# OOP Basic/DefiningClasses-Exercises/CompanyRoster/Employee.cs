namespace CompanyRoster
{
   public class Employee
   {
       public string name;
       public double selary;
       public string position;
       public string department;
       public string email;
       public int age;

       public Employee()
       {
           this.name = "";
           this.selary = 0.0;
           this.position = "";
           this.department = "";
           this.email = "n/a";
           this.age = -1;

       }

       public Employee(string name, double selary, string position, string department) : this()
       {
           this.name = name;
           this.selary = selary;
           this.position = position;
           this.department = department;
       }

       public Employee(string name, double selary, string position, string department, string email): this( name, selary, position, department)
       {
           this.email = email;
        }
       public Employee(string name, double selary, string position, string department, int age) : this(name, selary, position, department)
       {
           this.age = age;
       }

       public Employee(string name, double selary, string position, string department, string email, int age) :this()
       {
           this.name = name;
           this.selary = selary;
           this.position = position;
           this.department = department;
           this.email = email;
           this.age = age;
        }

       public double Selary
       {
           get { return this.selary; }
       }   
    }
}
