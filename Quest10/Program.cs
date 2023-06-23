using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest10
{
    class Program
    {
        static void Main(string[] args)
        {
            int mk1 = int.Parse(Console.ReadLine());
            int mk2 = int.Parse(Console.ReadLine());
            int mk3 = mk1 + mk2;
            int mk4 = mk1 - mk2;
            int mk5 = mk1 * mk2;
            int mk6 = mk1 / mk2;
            string result = $"{mk3} {mk4} {mk5} {mk6}";
            Console.WriteLine(result);
            Console.WriteLine("Программа завершена. Нажмите Enter для выхода.");
            Console.ReadLine();
            // изменение названия
        }
    }
}
