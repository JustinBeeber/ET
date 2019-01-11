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
        public void Step1_Successful_Test()
        {
          
            string sweets="";
            Assert.AreEqual(0, calc.TestCalculator(sweets));
        }

        [TestMethod]
        public void Step2_Successful_Test()
        {

            string sweets = "5      ";
            Assert.AreEqual(5, calc.TestCalculator(sweets));
        }
    }
}
