using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет");
            Console.WriteLine("Введите n-ное количество метров");
            string mk1 = Console.ReadLine();
            long mk2 = long.Parse(mk1);
            long mk3 = mk2 / 1000;
            string result1 = "Количество целых километров в веденных метрах - " + mk3;
            Console.WriteLine(result1);
            Console.WriteLine("Программа завершена. Нажмите Enter для выхода.");
            Console.ReadLine();
            // изменение названия
        }
    }
}
