using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest17
{
    class Program
    {
        static void Main(string[] args)
        {
            double rub = double.Parse(Console.ReadLine());
            double curs = double.Parse(Console.ReadLine());
            double cms = double.Parse(Console.ReadLine());
            double rub1 = rub - cms;
            int result = (int)(rub / curs);
            Console.WriteLine(result);
            Console.WriteLine("Программа завершена. Нажмите Enter для выхода.");
            Console.ReadLine();
        }
    }
}
