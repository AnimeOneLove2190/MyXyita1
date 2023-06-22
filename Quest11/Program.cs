using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest11
{
    class Program
    {
        static void Main(string[] args)
        {
            int mk1 = int.Parse(Console.ReadLine());
            int mk2 = int.Parse(Console.ReadLine());
            int mk3 = int.Parse(Console.ReadLine());
            int mk4 = mk1 + mk2 + mk3;
            Console.WriteLine(mk4);
            Console.WriteLine("Программа завершена. Нажмите Enter для выхода.");
            Console.ReadLine();
        }
    }
}
