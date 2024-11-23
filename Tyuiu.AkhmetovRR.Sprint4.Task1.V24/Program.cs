using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AkhmetovRR.Sprint4.Task1.V24.Lib;

namespace Tyuiu.AkhmetovRR.Sprint4.Task1.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[] numArray = ds.matrix1(16, 2, 5);
            int result = ds.Calculate(numArray);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
