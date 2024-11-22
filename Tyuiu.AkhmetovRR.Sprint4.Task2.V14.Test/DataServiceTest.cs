using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AkhmetovRR.Sprint4.Task2.V14.Lib;

namespace Tyuiu.AkhmetovRR.Sprint4.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[] numsWaitArray = { 3, 4, 2, 6, 3, 8, 7, 1, 5, 4, 1, 5 };
            int result = ds.Calculate(numsWaitArray);
            int wait = 1575;
            Assert.AreEqual(wait, result);
        }
    }
}
