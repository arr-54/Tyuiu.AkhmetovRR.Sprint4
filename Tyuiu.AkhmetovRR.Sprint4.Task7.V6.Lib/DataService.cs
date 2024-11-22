using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AkhmetovRR.Sprint4.Task7.V6.Lib
{
    public class DataService : ISprint4Task7V6
    {
        public int[,] Calculate(int rows, int columns, string value)
        {
            int[,] mtrx = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    mtrx[i, j] = int.Parse(value.Substring(i * columns + j, 1));
                }
            }

            return mtrx;
        }
        public int Nechet(int[,] mas3)
        {
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (mas3[i, j] % 2 == 1)
                    {
                        sum += mas3[i, j];
                    }
                }
            }
            return sum;
        }

        int ISprint4Task7V6.Calculate(int n, int m, string value)
        {
            throw new NotImplementedException();
        }
    }
}
