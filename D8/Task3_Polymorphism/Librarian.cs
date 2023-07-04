using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Librarian : User
    {
        public int salary;
        public int Salary { get; set; }
        public Librarian(string password) : base(password)
        {

        }
    }
}
