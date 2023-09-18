using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using ConsoleApplication1;

namespace HelloWorldTests
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected ="нечетное число";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                int check_number = 5;
                ConsoleApplication1.Example.CheckEvenNumber(check_number);

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}