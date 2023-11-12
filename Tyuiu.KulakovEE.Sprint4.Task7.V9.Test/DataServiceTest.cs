using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KulakovEE.Sprint4.Task7.V9.Lib;

namespace Tyuiu.KulakovEE.Sprint4.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int rows = 3;
            int colums = 3;
            int[,] mtrx = new int[rows, colums];
            string str = "864299753";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, colums, str);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}