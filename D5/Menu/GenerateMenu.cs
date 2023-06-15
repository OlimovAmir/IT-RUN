using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class GenerateMenu
    {


        public string value;
        public string Value
        {
            get { return this.value; }
            set { }
        }
        public string nameProduct;
        public string NameProduct { get; set; }

        public GenerateMenu(string value, string nameProduct)
        {
            List<string> productList = File.ReadAllLines("listProduct.txt").ToList();
            

            using (StreamWriter writer2 = new StreamWriter("listProduct.txt"))
            {

                productList.Add($"{nameProduct}");
               

                for (int i = 0; i < productList.Count; i++)
                {
                    string name = productList[i];

                    Console.WriteLine(name);
                }
                foreach (string arr in productList)
                {
                    writer2.WriteLine(arr);
                }
            }

            

            // Создаем файл и записываем в него тег
            using (StreamWriter writer = new StreamWriter("index.html"))
            {
                writer.WriteLine($"{value}");
                writer.Close();
               
            }




            // Проверяем, что файл создан
            if (File.Exists("index.html"))
            {
                Console.WriteLine("Файл успешно создан.");

            }
            else
            {
                Console.WriteLine("Ошибка при создании файла.");
            }
            //-----------------------------------
        }
    }
}
