using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest15
{
    class Program
    {
        static void Main(string[] args)
        {
            int r1 = int.Parse(Console.ReadLine());
            double pi = 3.14;
            double r2 = r1 * r1;
            double s = pi * r2;
            Console.WriteLine(s);
            Console.WriteLine("Программа завершена. Нажмите Enter для выхода.");
            Console.ReadLine();
        }
    }
}
