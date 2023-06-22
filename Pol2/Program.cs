using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pol2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет");
            Console.WriteLine("Введите имя и фамилию");
            string Fio1 = Console.ReadLine();
            Console.WriteLine("Теперь введите ваш пол (можно паркетный)");
            string Pol1 = Console.ReadLine();
            string Result1 = $"Имя: {Fio1} Пол: {Pol1}";
            Console.WriteLine(Result1);
            Console.WriteLine("Программа завершена. Нажмите Enter для выхода.");
            string mk1 = Console.ReadLine();
        }
    }
}
