using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest13
{
    class Program
    {
        static void Main(string[] args)
        {
            int mk1 = int.Parse(Console.ReadLine());
            int mk2 = mk1 / 10;
            int mk3 = mk1 % 10;
            string mk4 = $"{mk2} {mk3}";
            Console.WriteLine(mk4);
            Console.WriteLine("Программа завершена. Нажмите Enter для выхода.");
            Console.ReadLine();
        }
    }
}
