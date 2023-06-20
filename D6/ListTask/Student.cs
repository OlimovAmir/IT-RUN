using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTask
{
    public class Student
    {
        public int id;
        public string name;
        public string lastName;
        public string firstName;
        private int v1;
        private string v2;
        private string v3;
        private DateTime dateTime;

        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; }

        public Student(int id, string name, string lastName, string firstName, DateTime dateOfBirth)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;


            List<string> ListStudent = File.ReadAllLines("ListStudent.txt").ToList();

            using (StreamWriter writer2 = new StreamWriter("listProduct.txt"))
            {

                ListStudent.Add($"{id} {name} {lastName} {firstName} {dateOfBirth}");


                for (int i = 0; i < ListStudent.Count; i++)
                {
                    string st = ListStudent[i];

                    Console.WriteLine(st);
                }
                foreach (string arr in ListStudent)
                {
                    writer2.WriteLine(arr);
                }
            }
        }



    }
}
