using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest20
{
    class Program
    {
        static void Main(string[] args)
        {
            char mk1 = Console.ReadKey().KeyChar;
            mk1 = (char)(mk1 + 1);
            Console.WriteLine("");
            Console.WriteLine(mk1);
            Console.WriteLine("Программа завершена. Нажмите Enter для выхода.");
            Console.ReadLine();
            // изменение названия
        }
    }
}
