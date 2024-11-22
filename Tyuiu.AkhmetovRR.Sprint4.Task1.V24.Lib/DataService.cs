using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AkhmetovRR.Sprint4.Task1.V24.Lib
{
    public class DataService : ISprint4Task1V24
    {
        public int Calculate(int[] array)
        {
            throw new NotImplementedException();
        }

        public int[] matrix1(int i, int startValue, int stopValue)
        {
            int[] matrix = new int[i];
            for (int j = 0; j < i; j++)
            {
                matrix[j] = int.Parse(Console.ReadLine());
            }
            return matrix;
        }
        public int matrix3(int[] matrix)
        {
            int multpy = 1;
            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i] % 2 == 1)
                {
                    multpy *= matrix[i];
                }
            }
            return multpy;
        }
    }
}
