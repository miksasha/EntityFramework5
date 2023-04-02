using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MykhailenkoEF5
{
    class CompanyInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {
            var employeeList = new List<Employee>()
            {
                new Employee(){ Name = "Sasha", Surname = "Mykhailenko", Fathername = "Valeriivna", Position = "Lead generation manager", unitName = "Sales", Salary = 2000 },
                new Employee(){ Name = "Vania", Surname = "Martenko", Fathername = "Frankovuch", Position = "Sales generation manager", unitName = "Sales", Salary = 3000 },
                new Employee(){ Name = "Yana", Surname = "Byga", Fathername = "Sergiivna", Position = "Partnershop manager", unitName = "Partnership department", Salary = 2000 },
                new Employee(){ Name = "Daria", Surname = "Chernenko", Fathername = "Olegivna", Position = "Finance director", unitName = "Buhgalteria", Salary=3300 },
                new Employee(){ Name = "Freddy", Surname = "Bigvi", Fathername = "Victorovuch", Position = "Lead generation manager", unitName = "Sales", Salary=1200 },
                };
            employeeList.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();
        }
    }
}
