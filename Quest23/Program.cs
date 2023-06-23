using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest23
{
    class Program
    {
        static void Main(string[] args)
        {
            int lvx = int.Parse(Console.ReadLine());
            int lvy = int.Parse(Console.ReadLine());
            int pnx = int.Parse(Console.ReadLine());
            int pny = int.Parse(Console.ReadLine());
            int lnx = lvx;
            int lny = pny;
            int pvx = pnx;
            int pvy = lvy;
            string result = $"Левый нижний угол: x = {lnx}, y = {lny} Правый верхний угол: x = {pvx}, y = {pvy}";
            Console.WriteLine(result);
            Console.WriteLine("Программа завершена. Нажмите Enter для выхода.");
            Console.ReadLine();
        }
    }
}
