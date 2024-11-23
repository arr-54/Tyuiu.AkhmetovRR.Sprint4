using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AkhmetovRR.Sprint4.Task4.V21.Lib;

namespace Tyuiu.AkhmetovRR.Sprint4.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] numsWaitArray = { {5, 4, 9, 8, 5},
                                     {4, 6, 6, 9, 9},
                                     {9, 8, 4, 8, 8},
                                     {6, 8, 6, 8, 9},
                                     {9, 4, 6, 6, 7} };
            int result = ds.Calculate(numsWaitArray);
            int wait = 100;
            Assert.AreEqual(wait, result);
        }
    }
}
