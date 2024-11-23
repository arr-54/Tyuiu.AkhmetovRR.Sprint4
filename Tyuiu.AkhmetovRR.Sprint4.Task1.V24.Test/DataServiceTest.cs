using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AkhmetovRR.Sprint4.Task1.V24.Lib;

namespace Tyuiu.AkhmetovRR.Sprint4.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void validCalc()
        {
            DataService ds = new DataService();

            int[] numsWaitArray = { 5, 6 };
            int result = ds.Calculate(numsWaitArray);
            int wait = 5;
            Assert.AreEqual(wait, result);
        }
    }
}
