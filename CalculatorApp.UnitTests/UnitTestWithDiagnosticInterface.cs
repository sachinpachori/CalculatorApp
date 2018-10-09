using CalculatorService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CalculatorApp.UnitTests
{
    [TestClass]
    public class UnitTestWithDiagnosticInterface
    {
        Mock<IDiagnostics> mock = new Mock<IDiagnostics>();
        
        [TestMethod]
        public void InvalidOperationException()
        {
            var simple = new SimpleCalculator(mock.Object);
            var result = simple.Divide(5000, 0);
            Assert.IsTrue(result == -999, "ERROR");
        }

       [TestMethod]
        public void TestAddOperation()
        {
            var simple = new SimpleCalculator(mock.Object);
            var result = simple.Add(5000, 100);
            Assert.IsTrue(result == 5100, "ERROR");
        }

       [TestMethod]
        public void TestSubtractOperation()
        {
            var simple = new SimpleCalculator(mock.Object);
            var result = simple.Subtract(5000, 100);
            Assert.IsTrue(result == 4900, "ERROR");
        }

       [TestMethod]
        public void TestMultiplyOperation()
        {
            var simple = new SimpleCalculator(mock.Object);
            var result = simple.Multiply(5000, 10);
            Assert.IsTrue(result == 50000, "ERROR");
        }

       [TestMethod]
        public void TestDivideOperation()
        {
            var simple = new SimpleCalculator(mock.Object);
            var result = simple.Divide(5000, 10);
            Assert.IsTrue(result == 500, "ERROR");
        }
    }
}
