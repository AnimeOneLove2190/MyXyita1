using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest12
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp1 = double.Parse(Console.ReadLine());
            temp1 = (temp1 * 9 / 5) + 32;
            Console.WriteLine(temp1);
            Console.WriteLine("Программа завершена. Нажмите Enter для выхода.");
            Console.ReadLine();
        }
    }
}
