using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest22
{
    class Program
    {
        static void Main(string[] args)
        {
            int mk1 = int.Parse(Console.ReadLine());
            char mk2 = (char)(mk1);
            Console.WriteLine(mk2);
            Console.WriteLine("Программа завершена. Нажмите Enter для выхода.");
            Console.ReadLine();
        }
    }
}
