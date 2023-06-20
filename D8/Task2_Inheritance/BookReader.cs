using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class BookReader : User
    {
        public string favoriteBooks;
        public string FavoriteBooks { get; set; }
        public BookReader(string password) : base(password)
        {
            User user = new User("123456");
            user.Login();
        }
    }
}
