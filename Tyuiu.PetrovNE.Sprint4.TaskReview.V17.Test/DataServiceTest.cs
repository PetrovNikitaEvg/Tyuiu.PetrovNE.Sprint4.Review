using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PetrovNE.Sprint4.TaskReview.V17.Lib;

namespace Tyuiu.PetrovNE.Sprint4.TaskReview.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string str = "753159864";
            int rows = 3, columns = 3, res = ds.Calculate(rows, columns, str), wait = 3;
            int[,] mtrx = new int[rows, columns];
            Assert.AreEqual(res, wait);
        }
    }
}
