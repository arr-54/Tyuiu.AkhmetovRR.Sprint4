using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AkhmetovRR.Sprint4.Task3.V28.Lib
{
    public class DataService : ISprint4Task3V28
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            int count = matrix[3, 0];

            for (int i = 0; i < columns; i++)
            {
                if (count > matrix[3, i])
                {
                    count = matrix[3, i];
                }
            }
            return count;
        }
    }
}