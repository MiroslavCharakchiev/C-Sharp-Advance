using System;

namespace CompanyRoster
{
    public class StartUp
    {
        public static void Main()
        {
            var input = int.Parse(Console.ReadLine());

            var list = new Compary();
            for (int i = 0; i < input; i++)
            {
                var line = Console.ReadLine();
                var tokens = line.Split();

                var empName = tokens[0];
                var empSelary = double.Parse(tokens[1]);
                var empPosition = tokens[2];
                var empDepartment = tokens[3];
                if (tokens.Length == 4)
                {
                    var employee = new Employee(empName, empSelary, empPosition, empDepartment);
                    list.AddEmployee(employee);
                }
                else if (tokens.Length == 5)
                {
                    int empAge;
                    var isParsed = int.TryParse(tokens[4], out empAge);
                    if (isParsed)
                    {
                        var employee = new Employee(empName, empSelary, empPosition, empDepartment, empAge);
                        list.AddEmployee(employee);
                    }
                    else
                    {
                        var empEmail = tokens[4];
                        var employee = new Employee(empName, empSelary, empPosition, empDepartment, empEmail);
                        list.AddEmployee(employee);
                    }
                }
                else
                {
                    var empEmail = tokens[4];
                    var empAge = int.Parse(tokens[5]);
                    var employee = new Employee(empName, empSelary, empPosition, empDepartment, empEmail, empAge);
                    list.AddEmployee(employee);
                }
            }

        }
    }
}
