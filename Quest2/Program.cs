using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет");
            Console.WriteLine("Введите название продукта");
            string name1 = Console.ReadLine();
            Console.WriteLine("Теперь введите количество продукта");
            string colvo1 = Console.ReadLine();
            Console.WriteLine("А теперь введите цену продукта");
            string price1 = Console.ReadLine();
            string result1 = $"Название: {name1} Количество: {colvo1} Цена: {price1}";
            Console.WriteLine(result1);
            Console.WriteLine("Программа завершена. Нажмите Enter для выхода.");
            Console.ReadLine();
        }
    }
}
