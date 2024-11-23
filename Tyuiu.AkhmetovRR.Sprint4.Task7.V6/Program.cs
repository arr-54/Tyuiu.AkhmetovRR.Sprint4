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
            int sum = ds.Calculate(rows, columns, str);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
