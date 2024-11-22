using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AkhmetovRR.Sprint4.Task5.V29.Lib;

namespace Tyuiu.AkhmetovRR.Sprint4.Task5.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { {5, -3, -6, -4, 1},
                                     {-2, 6, 7, 3, 9},
                                     {0, 8, 4, -7, 0},
                                     {-2, -5, -8, 2, -6},
                                     {-5, -1, -9, 0, 7} };
            int res = ds.Calculate(mas2);
            int wait = 10;

            Assert.AreEqual(wait, res);
        }
    }
}
