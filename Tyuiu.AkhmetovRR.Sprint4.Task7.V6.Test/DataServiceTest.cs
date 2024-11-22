using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AkhmetovRR.Sprint4.Task7.V6.Lib;

namespace Tyuiu.AkhmetovRR.Sprint4.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string str = "458963214789";
            int rows = 3;
            int columns = 4;
            int[,] mtrx = ds.Calculate(rows, columns, str);
            int res = ds.Nechet(mtrx);
            int wait = 34;
            Assert.AreEqual(wait, res);
        }
    }
}