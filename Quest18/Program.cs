using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest18
{
    class Program
    {
        static void Main(string[] args)
        {
            double doll = double.Parse(Console.ReadLine());
            double curs = double.Parse(Console.ReadLine());
            double cms = double.Parse(Console.ReadLine());
            double result1 = doll * curs + cms;
            int result2 = (int)(result1);
            Console.WriteLine(result1);
            Console.WriteLine("Программа завершена. Нажмите Enter для выхода.");
            Console.ReadLine();
        }
    }
}
