using Microsoft.VisualStudio.TestTools.UnitTesting;
using ISR.CL;
using System;

namespace ISR.Tests {
    [TestClass]
    public class ISRTax_TestClass {
        private static decimal isrCalculated = 0;
        [TestMethod]
        public void Calculate_ISR_For_P25000M() {
            isrCalculated = ISRTax.Calculate(25000, true);
            Assert.AreEqual(isrCalculated, 0);
        }
        [TestMethod]
        public void Calculate_ISR_For_P30000M() {
            isrCalculated = ISRTax.Calculate(30000, true);
            Assert.AreEqual(isrCalculated, 550);
        }
        [TestMethod]
        public void Calculate_ISR_For_P50000M() {
            isrCalculated = ISRTax.Calculate(50000, true);
            Assert.AreEqual(Math.Round(isrCalculated, 0), 4733);
        }
        [TestMethod]
        public void Calculate_ISR_For_P75000M() {
            isrCalculated = ISRTax.Calculate(75000, true);
            Assert.AreEqual(Math.Round(isrCalculated, 0), 12167);
        }

        [TestMethod]
        public void Calculate_ISR_For_P300000A() {
            isrCalculated = ISRTax.Calculate(300000, false);
            Assert.AreEqual(isrCalculated, 0);
        }
        [TestMethod]
        public void Calculate_ISR_For_P360000A() {
            isrCalculated = ISRTax.Calculate(360000, false);
            Assert.AreEqual(isrCalculated, 550);
        }
        [TestMethod]
        public void Calculate_ISR_For_P600000A() {
            isrCalculated = ISRTax.Calculate(600000, false);
            Assert.AreEqual(Math.Round(isrCalculated, 0), 4733);
        }
        [TestMethod]
        public void Calculate_ISR_For_P900000A() {
            isrCalculated = ISRTax.Calculate(900000, false);
            Assert.AreEqual(Math.Round(isrCalculated, 0), 12167);
        }
        [TestMethod]
        public void Calculate_ISR_For_N1000M() {
            isrCalculated = ISRTax.Calculate(-1000,true);
            Assert.AreEqual(isrCalculated, -1);
        }
        [TestMethod]
        public void Calculate_ISR_For_N45000M() {
            isrCalculated = ISRTax.Calculate(-45000, true);
            Assert.AreEqual(isrCalculated, -1);
        }
        [TestMethod]
        public void Calculate_ISR_For_N12000A() {
            isrCalculated = ISRTax.Calculate(-12000, false);
            Assert.AreEqual(isrCalculated, -1);
        }
        [TestMethod]
        public void Calculate_ISR_For_N540000A() {
            isrCalculated = ISRTax.Calculate(-540000, false);
            Assert.AreEqual(isrCalculated, -1);
        }
    }
}
