using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AkhmetovRR.Sprint4.Task6.V20.Lib;

namespace Tyuiu.AkhmetovRR.Sprint4.Task6.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            var predmet = new string[] { "Математика", "Физика", "Химия", "Биология", "География", "История", "Литература" };

            Console.WriteLine("Исходный массив: ");

            string[] mas = ds.Calculate(predmet);

            for (int i = 0; i <= predmet.Length - 1; i++)
            {
                Console.WriteLine(predmet[i]);
            }
            Console.WriteLine("элементы, длина которых меньше 10 символов");
            for (int i = 0; i <= mas.Length - 1; i++)
            {
                Console.WriteLine(mas[i]);
            }
            Console.ReadKey();
        }
    }
}
