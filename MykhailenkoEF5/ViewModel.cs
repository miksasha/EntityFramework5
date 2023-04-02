using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MykhailenkoEF5
{
    public class ViewModel
    {
        public List<Employee> Employees { get; set; }
        public ViewModel()
        {
            var context = new ApplicationContext();
            Employees = context.Employees.ToList();
        }
    }

}
