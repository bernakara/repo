using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CsharpLibrary;

namespace CsharpDllTestSample
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WrongSumTest()
        {
            calculation calc = new calculation();
            Assert.IsTrue(calc.Add(1, 2) == 3);
            Console.WriteLine("Add Sample " + calc.Add(1, 2));
            
           

        }
        [TestMethod]
        public void WrongSubTest()
        {
            calculation calc = new calculation();
            Assert.IsFalse(calc.sub(1, 2) == 3);
           
            
            Console.WriteLine("Sub Sample " + calc.sub(1, 2));


        }

    }
}
