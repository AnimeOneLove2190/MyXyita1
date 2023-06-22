using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest14
{
    class Program
    {
        static void Main(string[] args)
        {
            int dl = int.Parse(Console.ReadLine());
            int shr = int.Parse(Console.ReadLine());
            int P = dl * 2 + shr * 2;
            int S = dl * shr;
            string result1 = $"P = {P} S = {S}";
            Console.WriteLine(result1);
            Console.WriteLine("Программа завершена. Нажмите Enter для выхода.");
            Console.ReadLine();
        }
    }
}
