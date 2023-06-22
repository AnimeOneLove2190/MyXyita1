using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше ФИО");
            string fio1 = Console.ReadLine();
            string result1 = "Привет, " + fio1 + "!";
            Console.WriteLine(result1);
            Console.WriteLine("Программа завершена. Нажмите Enter для выхода.");
            Console.ReadLine();
        }
    }
}
