using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AkhmetovRR.Sprint4.Task2.V14.Lib;

namespace Tyuiu.AkhmetovRR.Sprint4.Task2.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Write("Введите количество элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] numsArry = ds.rnd(len, 1, 8);

            Console.WriteLine("Массив :");
            for (int i = 0; i < len; i++)
            {
                Console.Write(numsArry[i] + "\t");
            }

            Console.WriteLine();

            int res = ds.Calculate(numsArry);

            Console.WriteLine("Произведение нечетных элементов= " + res);
            Console.ReadKey();
        }
    }
}