using System.Collections.Generic;

namespace _03.Detail_Printer
{
    public class Program
    {
        public static void Main()
        {
            var list = new List<string>(){"miro", "pesho", "falit"};
            var manager = new Manager("Pesho", list);
            var emp = new Employee("miro");

            var listOfEmployee = new List<Employee>();
            listOfEmployee.Add(emp);
            listOfEmployee.Add(manager);

            var detailsPrinter = new DetailsPrinter(listOfEmployee);

            detailsPrinter.printDetails();
        }
    }
}
