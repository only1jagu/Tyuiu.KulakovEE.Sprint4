using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KulakovEE.Sprint4.Task4.V3.Lib;

namespace Tyuiu.KulakovEE.Sprint4.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[,] { { 7, 9, 7, 8, 6 }, { 4, 4, 4, 8, 6 }, { 7, 9, 6, 7, 6 }, { 7, 5, 4, 9, 8 }, { 9, 6, 4, 9, 8 } };
            int wait = 85;

            int res = ds.Calculate(matrix);
            Assert.AreEqual(wait, res);
        }
    }
}