using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя");
            string name1 = Console.ReadLine();
            string result1 = "Привет, " + name1 + "!";
            Console.WriteLine(result1);
            Console.WriteLine("Программа завершена. Нажмите Enter для выхода.");
            Console.ReadLine();
            // изменение названия
        }
    }
}
