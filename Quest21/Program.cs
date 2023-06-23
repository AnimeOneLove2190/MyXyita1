using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest21
{
    class Program
    {
        static void Main(string[] args)
        {
            char mk1 = Console.ReadKey().KeyChar;
            int mk2 = (int)(mk1);
            Console.WriteLine("");
            Console.WriteLine(mk2);
            Console.WriteLine("Программа завершена. Нажмите Enter для выхода.");
            Console.ReadLine();
        }
    }
}
