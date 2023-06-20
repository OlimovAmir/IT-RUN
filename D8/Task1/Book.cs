using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Book
    {
        // public string title;
        // public string author;
        // public string genre;

        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }


        public Book(string title, string author, string genre, string v)
        {

            Title = title;
            Author = author;
            Genre = genre;
            
            //AddLineToFile("строка для добавления");


        }

        public Book(string title, string author, string genre)
        {
            Title = title;
            Author = author;
            Genre = genre;
        }
    }



}

class Remove
{
    public void RemoveLineFromFile(string lineToRemove)
    {
        // реализация метода удаления строки из файла
        string[] lines = File.ReadAllLines("ListBook.txt");

        // Поиск строки для удаления
        for (int i = 0; i < lines.Length; i++)
        {
            if (lines[i].Contains(lineToRemove))
            {
                Console.WriteLine("Строка найдена");
                // Удаление строки
                lines[i] = "";
            }
            
        }
        using (StreamWriter writer = new StreamWriter("ListBook.txt"))
        {
            foreach (string line in lines)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    writer.WriteLine(line);
                }
            }
        }

    }
}

class Search
{
    public void SearchLineFromFile(string lineToRemove) 
    {
       // Чтение содержимого файла в массив строк
         string[] lines = File.ReadAllLines("ListBook.txt");
        // Поиск строки для удаления
        for (int i = 0; i < lines.Length; i++)
        {
            if (lines[i].Contains(lineToRemove))
            {
                // Вывод строки в консоль
                
                Console.WriteLine($"По вашему запросу найдено Книга\n {lines[i]}");
            }
            
        }
    }
}
