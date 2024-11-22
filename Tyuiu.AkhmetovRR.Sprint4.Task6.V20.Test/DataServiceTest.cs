using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AkhmetovRR.Sprint4.Task6.V20.Lib;

namespace Tyuiu.AkhmetovRR.Sprint4.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var predmet = new string[] { "����������", "������", "�����", "��������", "���������", "�������", "����������" };
            string[] mas = new string[] { "������", "�����", "��������", "���������", "�������" };
            string[] wait = ds.Calculate(predmet);
            CollectionAssert.AreEqual(wait, mas);
        }
    }
}
