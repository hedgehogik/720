using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            double raznost, max, min;
            max = 0;
            min = 100000;
            Console.WriteLine("Введите размер массива: ");
            n = int.Parse(Console.ReadLine());
            double[] mas = new double[n];
            Console.WriteLine("Введите элементы массива: ");
            for (int i=0; i < n; i++)
            {
                mas[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (mas[i] > max)
                {
                    max = mas[i];
                }
                if (mas[i] < min)
                {
                    min = mas[i];
                }
            }
            raznost = max - min;
            Console.WriteLine("Разность максимального - {0} и минимального - {1} элементов массива = {2}",max,min,raznost);
        }
    }
}
