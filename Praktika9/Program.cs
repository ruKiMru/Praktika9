using System;

namespace Praktika9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите длину двунаправленного списка:");
            int size = InputInteger(1, 100);
            var beg = PointBiList.MakeList(size);

            PointBiList.Print(beg);

            Console.WriteLine("Сумма информационных полей:");
            Console.WriteLine(PointBiList.Sum(beg));

            Console.WriteLine("Сумма информационных полей через рекурсию:");
            Console.WriteLine(PointBiList.SumRec(beg));
        }

        private static int InputInteger(int min, int max)
        {
            int output;

            while (!int.TryParse(Console.ReadLine(), out output) ||
                   !(output >= min && output <= max))
            {
                Console.WriteLine("Введите целое число от " + min + " до " + max);
            }

            return output;
        }
    }
}
