using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace Task1


{

    internal class LibraryService : Book
    {


        public LibraryService(string title, string author, string genre) : base(title, author, genre)

        {

            List<string> ListBook = File.ReadAllLines("ListBook.txt").ToList();

            using (StreamWriter writer2 = new StreamWriter("ListBook.txt", true))
            {
                ListBook.Add($"Название: {title} Автор: {author} Жанр: {genre}");
                writer2.WriteLine($"Название: {title} Автор: {author} Жанр: {genre}");

                Console.WriteLine($"Новый Запись произведен -- Название: {title} Автор: {author} Жанр: {genre} ");
                Console.WriteLine();
            }
            ListBook.ForEach(x => Console.WriteLine(x));



        }

    }

}
