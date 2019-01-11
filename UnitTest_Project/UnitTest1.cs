using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata_Emilio_Trev;

namespace UnitTest_Project
{
    [TestClass]
    public class UnitTest1
    {
        public String_Calculator calc = new String_Calculator();

        [TestMethod]
        public void TestMethod1()
        {
          
            string sweets="";
            Assert.AreEqual(0, calc.TestCalculator(sweets));
        }
    }
}
