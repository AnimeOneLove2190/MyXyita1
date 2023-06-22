using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest16
{
    class Program
    {
        static void Main(string[] args)
        {
            int mk1 = int.Parse(Console.ReadLine());
            int mk2 = int.Parse(Console.ReadLine());
            int mk3 = mk1;
            mk1 = mk2;
            mk2 = mk3;
            string result = $"{mk1} {mk2}";
            Console.WriteLine(result);
            Console.WriteLine("Программа завершена. Нажмите Enter для выхода.");
            Console.ReadLine();
        }
    }
}
