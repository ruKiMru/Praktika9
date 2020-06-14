using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika9
{
    class PointBiList
    {
        // Информационное поле
        public int data;

        // Адрес следующего элемента
        public PointBiList next;

        // Адрес предыдущего элемента
        public PointBiList pred;

        static private Random rand = new Random();

        public PointBiList()
        {
            data = rand.Next(-20, 20);
            next = null;
            pred = null;
        }

        public PointBiList(int num)
        {
            data = num;
            next = null;
            pred = null;
        }

        public override string ToString()
        {
            return data + " ";
        }

        // Создание элемента списка
        static PointBiList MakePoint(int num)
        {
            PointBiList p = new PointBiList(num);
            return p;
        }

        // Создание двунаправленного списка
        public static PointBiList MakeList(int size)
        {
            PointBiList beg = MakePoint(rand.Next(-20, 20));
            for (int i = 1; i < size; i++)
            {
                PointBiList p = MakePoint(rand.Next(-20, 20));
                p.next = beg;
                beg.pred = p;
                beg = p;
            }

            return beg;
        }

        public static void Print(PointBiList beg)
        {
            // Проверка наличия элементов в списке
            if (beg == null)
            {
                Console.WriteLine("Список пустой");
                return;
            }

            PointBiList p = beg;

            Console.WriteLine("Список:");
            while (p != null)
            {
                Console.WriteLine(p.ToString());
                // Переход к следующему элементу
                p = p.next;
            }
        }

        public static int Sum(PointBiList beg)
        {
            int sum = 0;

            PointBiList p = beg;
            while (p != null)
            {
                sum += p.data;
                // Переход к следующему элементу
                p = p.next;
            }

            return sum;
        }

        public static int SumRec(PointBiList beg, int sum = 0)
        {
            PointBiList p = beg;
            if (p != null)
            {
                sum += p.data;
                // Переход к следующему элементу
                return SumRec(p.next, sum);
            }

            return sum;
        }
    }
}
