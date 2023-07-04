// See https://aka.ms/new-console-template for more information


using System.Net.Security;
using Task1;


BookReader bookReader = new BookReader("12345");
bookReader.Login();


Console.WriteLine("Выбирите действие");
Console.WriteLine();
Console.WriteLine("1) Добавить книгу\n2) Удалить книгу\n3) Поиск");
string choes = Console.ReadLine();
switch (choes)
{
    case "1":
        Console.WriteLine("Введите навание Книги");
        string title = Console.ReadLine();
        Console.WriteLine("Введите Автор Книги");
        string author = Console.ReadLine();
        Console.WriteLine("Введите Жанр Книги");
        string genre = Console.ReadLine();
        LibraryService libraryService2 = new LibraryService($"{title}", $"{author}", $"{genre}");
        break;

    case "2":
        Console.WriteLine("Вводите название книги для удаление");
        Remove remove = new Remove();
        remove.RemoveLineFromFile(Console.ReadLine());
        
        
        break;

    case "3":
        Console.WriteLine("Вводите название книги для Поиска");
        Search search = new Search();
        search.SearchLineFromFile(Console.ReadLine());

        break;


    default:
        Console.WriteLine("Value didn't match earlier.");
        break;

}
