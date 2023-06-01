// See https://aka.ms/new-console-template for more information


using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

string command = "";
while (command != "выход") // цикл будет выполняться, пока не будет введена команда "exit"
{

    Console.WriteLine("    Выберите действия: Наберите нужную вам цифру затем кнопку ENTER");

    Console.WriteLine("1. Показать список продуктов");
    Console.WriteLine("2. Продать продукт");
    Console.WriteLine("3. Добавить новый продукт");
    Console.WriteLine("");
    Console.WriteLine("или наберите команду выход чтобы выйте из программы");
    string products = Console.ReadLine();
    //command = Console.ReadLine();

    switch (products)
    {
        case "1":
            Console.Clear();
            Console.WriteLine(File.ReadAllText("list.txt"));
            break;
        case "2":
            // Продажа продукта
            Console.Clear();

            Console.WriteLine("Вводите название продукта");
            string newProductName = Console.ReadLine();
            Console.WriteLine("Вводите количестко продукта");
            int countProduct = Convert.ToInt32(Console.ReadLine());

            string filelist = "list.txt";
            string fileContent0 = File.ReadAllText(filelist);
            string searchLine = newProductName; //строка, которую ищем
            string foundLine = File.ReadLines(filelist).FirstOrDefault(line => line.Contains(searchLine));
            // метод FirstOrDefault возвращает первый элемент из последовательности, удовлетворяющий заданному условию


            if (foundLine != null)
            {
                var newArrList = foundLine.Split(' ');
                int countOfProduct1 = int.Parse(newArrList[1]);
                int sumCountProduct1 = countOfProduct1 - countProduct;
                string filePath2 = "list.txt";
                string oldString = foundLine;
                Console.WriteLine($"Найдена строка: {foundLine}");
                if (File.Exists(filelist))
                {
                    string fileContent = File.ReadAllText(filelist);
                    fileContent = fileContent.Replace(oldString, $"{newProductName} {sumCountProduct1}");
                    File.WriteAllText(filePath2, fileContent);
                    Console.WriteLine("Товар продан");
                    Console.WriteLine("Остаток товара на складе  " + $"{newProductName} {sumCountProduct1}" + Environment.NewLine);

                    break;
                }
            }
            else
            {
                Console.WriteLine("Товар не найдена");
            }

            break;
        case "3":
            Console.Clear();
            // Добавить продукт
            Console.WriteLine("Вводите название продукта");
            string newProductName2 = Console.ReadLine();
            Console.WriteLine("Вводите количестко продукта");
            int countProduct2 = Convert.ToInt32(Console.ReadLine());

            string filelist2 = "list.txt";
            string fileContent4 = File.ReadAllText(filelist2);
            string searchLine2 = newProductName2; //строка, которую ищем

            string foundLine2 = File.ReadLines(filelist2).FirstOrDefault(line2 => line2.Contains(searchLine2));
            // метод FirstOrDefault возвращает первый элемент из последовательности, удовлетворяющий заданному условию
            if (foundLine2 != null)
            {
                var newArrList2 = foundLine2.Split(' ');
                int countOfProduct2 = int.Parse(newArrList2[1]);
                int sumCountProduct2 = countOfProduct2 + countProduct2;
                string filePath2 = "list.txt";
                string oldString2 = foundLine2;
                Console.WriteLine($"Найдена строка: {foundLine2}");
                if (File.Exists(filelist2)) // если массив содержит товар
                {
                    string fileContent2 = File.ReadAllText(filelist2);
                    fileContent2 = fileContent2.Replace(oldString2, $"{newProductName2} {sumCountProduct2}");
                    File.WriteAllText(filePath2, fileContent2);
                    Console.WriteLine("Товар приобретен");
                    Console.WriteLine("Остаток товара на складе  " + $"{newProductName2} {sumCountProduct2}" + Environment.NewLine);

                    break;

                }

            }
            else
            {

                // Открываем файл для записи
                using (StreamWriter writer = new StreamWriter("list.txt", true))
                {
                    writer.WriteLine();

                }
                File.AppendAllText("list.txt", $"{newProductName2} {countProduct2}" + Environment.NewLine); // Запись информации и переход на новую строку
                Console.WriteLine("Новый Товар записан");
            }







            break;
        case "выход":
            return;
            break;

        default:
            Console.WriteLine("Выбор не верный");
            break;
    }
}