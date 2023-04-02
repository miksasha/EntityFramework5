using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MykhailenkoEF5
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fathername { get; set; }
        public string Position { get; set; }
        public string unitName { get; set; }
        public int Salary { get; set; }
    }
}
