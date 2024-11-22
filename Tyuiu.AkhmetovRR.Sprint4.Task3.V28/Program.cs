using Tyuiu.AkhmetovRR.Sprint4.Task3.V28.Lib;

namespace Tyuiu.AkhmetovRR.Sprint4.Task3.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                int[,] mtrx = new int[5, 5] { {5, 4, 9, 8, 5},
                                        {4, 6, 6, 9, 9},
                                        {9, 8, 4, 8, 8},
                                        {6, 8, 6, 8, 9},
                                        {9, 4, 6, 6, 7} };

                int rows = mtrx.GetUpperBound(0) + 1;
                int columns = mtrx.Length / rows;

                DataService ds = new DataService();
                Console.WriteLine("Массив: ");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"{mtrx[i, j]} \t");
                    }

                    Console.WriteLine();
                }
                int res = ds.Calculate(mtrx);

                Console.WriteLine("Минимальный элемент в четвертом столбце: " + res);
                Console.ReadKey();
            }
        }
    }
}
