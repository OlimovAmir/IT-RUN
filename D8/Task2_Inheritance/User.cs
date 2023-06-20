using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class User
    {
        public int id;
        public string name;
        public string lastName;
        public string userName;
        private string password;

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        private string Password { get; set; }

        public User(string password)
        {
            this.password = password;
        }

        

        public void Login()
        {
            Console.Write("Enter password: ");
            string inputPassword = Console.ReadLine();

            if (inputPassword == password)
            {
                Console.WriteLine("Login successful!");
            }
            else
            {
                Console.WriteLine("Incorrect password.");
            }
        }
    }
}
