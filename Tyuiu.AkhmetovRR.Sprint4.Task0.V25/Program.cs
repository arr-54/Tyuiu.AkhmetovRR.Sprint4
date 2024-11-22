using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AkhmetovRR.Sprint4.Task0.V25.Lib;

namespace Tyuiu.AkhmetovRR.Sprint4.Task0.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[] numArray = { 1, 4, 2, 6, 4, 8, 6, 7, 8, 4 };
            int result = ds.Calculate(numArray);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}