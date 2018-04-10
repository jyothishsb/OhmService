using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OhmService.Models;

namespace OhmService.Tests
{
    [TestClass]
    public class OhmValueCalculatorTest
    {
        [TestMethod]
        public void ShouldReturnCorrectOhmValueWithNormalBandColorValues()
        {
            var resistor = new OhmValueCalculator();
            var ohmValue=resistor.CalculateOhmValue("blue", "green", "yellow", "gold");
            Assert.IsNotNull(ohmValue);
            Assert.AreEqual(682500, ohmValue);
        }
        [TestMethod]
        public void ShouldReturnCorrectOhmValueWithBandColorsUpperCase()
        {
            var resistor = new OhmValueCalculator();
            var ohmValue = resistor.CalculateOhmValue("BLUE", "GREEN", "YELLOW", "GOLD");
            Assert.IsNotNull(ohmValue);
            Assert.AreEqual(682500, ohmValue);
        }
        [TestMethod]
        public void ShouldReturnCorrectOhmValueWithToleranceNoneValue()
        {
            var resistor = new OhmValueCalculator();
            var ohmValue = resistor.CalculateOhmValue("green", "violet", "silver", "none");
            Assert.IsNotNull(ohmValue);
            Assert.AreEqual(1, ohmValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldThrowArgumentExceptionWhenBandAisInvalid()
        {
            var resistor = new OhmValueCalculator();
            var ohmValue = resistor.CalculateOhmValue("", "violet", "silver", "none");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldThrowArgumentExceptionWhenBandBisInvalid()
        {
            var resistor = new OhmValueCalculator();
            var ohmValue = resistor.CalculateOhmValue( "violet", "","silver", "none");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldThrowArgumentExceptionWhenBandCisInvalid()
        {
            var resistor = new OhmValueCalculator();
            var ohmValue = resistor.CalculateOhmValue("violet", "silver", "","none");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldThrowArgumentExceptionWhenBandDisInvalid()
        {
            var resistor = new OhmValueCalculator();
            var ohmValue = resistor.CalculateOhmValue("violet", "silver","green", "");
        }
    }
}
