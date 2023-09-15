using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GaleevTS.Sprint0.Task2.V0.Lib;
namespace Tyuiu.GaleevTS.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Тимур";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Тимур", res);
        }
    }
}
