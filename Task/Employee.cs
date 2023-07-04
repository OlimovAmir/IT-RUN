using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Employee : BaseUser
    {
        public int Salary { get; set; }
        public int Position { get; set; }
        public string Departament { get; set; }
    }
}
