using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, stepen;
            Console.WriteLine("Введите число А: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число B: ");
            b = int.Parse(Console.ReadLine());
            stepen = 1;
            for(int i=0; i<b; i++)
            {
                stepen *= a;
            }
            Console.WriteLine("Число {0} в степени {1} = {2}",a,b,stepen);
        }
    }
}
