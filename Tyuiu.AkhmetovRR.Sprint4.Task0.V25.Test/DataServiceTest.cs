using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AkhmetovRR.Sprint4.Task0.V25.Lib;
namespace Tyuiu.AkhmetovRR.Sprint4.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void validCalc()
        {
            DataService ds = new DataService();


            int[] numsWaitArray = { 1, 4, 2, 6, 4, 8, 6, 7, 8, 4 };
            int result = ds.Calculate(numsWaitArray);
            int wait = 42;
            Assert.AreEqual(wait, result);
        }
    }
}