using NUnit.Framework;
using SolidFeeCalculator;
using System;

namespace SolidFeeCalculatorTest
{
    
    
    [TestFixture]
    public class ProgramTest
    {
        [Test]
        public void CalculateFeeTest()
        {
            int userType = 1; 
            int itemType = 1; 
            int itemPrice = 500;
            DateTime itemEndDate = DateTime.Today; 
            int expected = 40; 
            decimal actual;
            actual = Program.CalculateFee(userType, itemType, itemPrice, itemEndDate);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
        [Test]
        public void CalculateFeeTest2()
        {
            int userType = 0; 
            int itemType = 0; 
            int itemPrice = 100; 
            DateTime itemEndDate = DateTime.Parse("2019-05-23");
            int expected = 32; //
            decimal actual;
            actual = Program.CalculateFee(userType, itemType, itemPrice, itemEndDate);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
        [Test]
        public void CalculateFeeTest3()
        {
            int userType = 1; 
            int itemType = 1; 
            int itemPrice = 513; 
            DateTime itemEndDate = DateTime.Today; 
            decimal expected = 40.52m; 
            decimal actual;
            actual = Program.CalculateFee(userType, itemType, itemPrice, itemEndDate);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
