using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AkhmetovRR.Sprint4.Task4.V21.Lib;

namespace Tyuiu.AkhmetovRR.Sprint4.Task4.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] mtrx = ds.matrix2(5, 5, 3, 8);

            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)

            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }

                Console.WriteLine();
            }
            int res = ds.matrix3(mtrx);

            Console.WriteLine("Сумма четных элементов: " + res);
            Console.ReadKey();
        }
    }
}

