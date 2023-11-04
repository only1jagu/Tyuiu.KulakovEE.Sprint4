using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KulakovEE.Sprint4.Task2.V12.Lib;

namespace Tyuiu.KulakovEE.Sprint4.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int[] nums = { 4, 3, 3, 9, 5, 6, 5, 6, 4, 5, 7, 3, 6, 4 };
            int res = dataService.Calculate(nums), wait = 40;
            Assert.AreEqual(wait, res);
        }
    }
}
