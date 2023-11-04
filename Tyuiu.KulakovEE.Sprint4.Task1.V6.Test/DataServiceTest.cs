using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KulakovEE.Sprint4.Task1.V6.Lib;




namespace Tyuiu.KulakovEE.Sprint4.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 2, 4, 4, 7, 2, 5, 4, 3, 3, 4 };
            Assert.AreEqual(ds.Calculate(array), 1024);
        }
    }
}