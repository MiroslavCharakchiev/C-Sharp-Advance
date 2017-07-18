using System.Collections.Generic;

namespace CompanyRoster
{
   public class Compary
    {

        public List<Employee> company;

        public Compary()
        {
            this.company = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            company.Add(employee);
        }

        public Compary HighestAverageSelary(List<Employee> company)
        {
        }
    }
}
