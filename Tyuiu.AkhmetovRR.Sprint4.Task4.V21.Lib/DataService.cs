using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AkhmetovRR.Sprint4.Task4.V21.Lib
{
    public class DataService : ISprint4Task4V21
    {
        public int Calculate(int[,] matrix4)
        {
            int rows = matrix4.GetUpperBound(0) + 1;
            int columns = matrix4.Length / rows;
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix4[i, j] % 2 == 0)
                    {
                        sum += matrix4[i, j];
                    }
                }
            }
            return sum;
        }
        public int[,] matrix2(int size1, int size2, int startValue, int stopValue)
        {
            int[,] matrix2 = new int[size1, size2];
            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return matrix2;
        }
    }
}