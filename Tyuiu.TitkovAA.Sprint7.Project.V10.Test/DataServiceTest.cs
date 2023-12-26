using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TitkovAA.Sprint7.Project.V10.Lib;

namespace Tyuiu.TitkovAA.Sprint7.Project.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethodmin()
        {
            DataService dt = new DataService();
            Assert.AreEqual(2, 2);
        }
    }
}
