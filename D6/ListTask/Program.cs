// See https://aka.ms/new-console-template for more information

using ListTask;

Person person = new Person(1990, 10, 15);
Console.WriteLine("Дата рождения: " + person.Birthdate.ToString("dd.MM.yyyy"));

StudentService student = new();
