using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest6
{
    class Program
    {
        static void Main(string[] args)
        {
            int mk1 = int.Parse(Console.ReadLine());
            mk1 = mk1 * 1000;
            Console.WriteLine(mk1);
            Console.WriteLine("Программа завершена. Нажмите Enter для выхода.");
            Console.ReadLine();
        }
    }
}
