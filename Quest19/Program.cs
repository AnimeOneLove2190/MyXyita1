using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest19
{
    class Program
    {
        static void Main(string[] args)
        {
            int shr = int.Parse(Console.ReadLine());
            int dl = int.Parse(Console.ReadLine());
            int H = int.Parse(Console.ReadLine());
            int V = shr * dl * H;
            Console.WriteLine(V);
            Console.WriteLine("Программа завершена. Нажмите Enter для выхода.");
            Console.ReadLine();
            // изменение названия
        }
    }
}
