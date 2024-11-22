using System.Text;
using System.Threading.Tasks;
using Tyuiu.AkhmetovRR.Sprint4.Task7.V6.Lib;

namespace Tyuiu.AkhmetovRR.Sprint4.Task7.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int rows = 3;
            int columns = 4;
            string str = "458963214789";
            int[,] mtrx = ds.Calculate(rows, columns, str);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(mtrx[i, j] + " ");
                }
                Console.WriteLine();
            }
            int sum = ds.Nechet(mtrx);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
