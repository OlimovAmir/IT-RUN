// See https://aka.ms/new-console-template for more information
using ManagedAndUnmanaged;
using static System.Net.Mime.MediaTypeNames;

while (true)
{
    Console.WriteLine("Choose operation:");

    var operation = Console.ReadLine();
    if (operation == "enter")
    {
        Console.WriteLine("Name:");
        var name = Console.ReadLine();

        Console.WriteLine("Count:");
        var count = int.Parse(Console.ReadLine());

        using (FileManager application = new FileManager())
        {
            application.WriteProduct(name, count);
        }
    }
}