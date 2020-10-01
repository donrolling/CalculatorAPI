using Microsoft.Extensions.DependencyInjection;
using CalculationEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculationTests
{
    [TestClass]
    public class MathEngineTests : TestBase
    {
        private readonly IMathEngine _mathEngine;

        public MathEngineTests()
        {
            _mathEngine = ServiceProvider.GetService<IMathEngine>();
        }

        [TestMethod]
        public void ItShouldAddIntegersCorrectly()
        {
            // arrange 
            var a = 3;
            var b = 4;
            var expectedResult = 7;

            // act
            var result = _mathEngine.Add(a, b);

            // assert
            Assert.AreEqual(expectedResult, result, $"Adding integers { a } + { b } should equal { expectedResult }, yet yielded { result }.");
        }

        [TestMethod]
        public void ItShouldAddDecimalsCorrectly()
        {
            // arrange 
            var a = 2.5m;
            var b = 3.5m;
            var expectedResult = 6;

            // act
            var result = _mathEngine.Add(a, b);

            // assert
            Assert.AreEqual(expectedResult, result, $"Adding decimals { a } + { b } should equal { expectedResult }, yet yielded { result }.");
        }

        [TestMethod]
        public void ItShouldSubtractIntegersCorrectly()
        {
            // arrange 
            var a = 5;
            var b = 3;
            var expectedResult = 2;

            // act
            var result = _mathEngine.Subtract(a, b);

            // assert
            Assert.AreEqual(expectedResult, result, $"Subtracting integers { a } - { b } should equal { expectedResult }, yet yielded { result }.");
        }

        [TestMethod]
        public void ItShouldSubtractDecimalsCorrectly()
        {
            // arrange 
            var a = 5.6m;
            var b = 3.2m;
            var expectedResult = 2.4m;

            // act
            var result = _mathEngine.Subtract(a, b);

            // assert
            Assert.AreEqual(expectedResult, result, $"Subtracting decimals { a } - { b } should equal { expectedResult }, yet yielded { result }.");
        }

        [TestMethod]
        public void ItShouldMultiplyIntegersCorrectly()
        {
            // arrange 
            var a = 5;
            var b = 2;
            var expectedResult = 10;

            // act
            var result = _mathEngine.Multiply(a, b);

            // assert
            Assert.AreEqual(expectedResult, result, $"Multiplying integers { a } * { b } should equal { expectedResult }, yet yielded { result }.");
        }

        [TestMethod]
        public void ItShouldMultiplyDecimalsCorrectly()
        {
            // arrange 
            var a = 5.5m;
            var b = 2.25m;
            var expectedResult = 12.375m;

            // act
            var result = _mathEngine.Multiply(a, b);

            // assert
            Assert.AreEqual(expectedResult, result, $"Multiplying decimals { a } * { b } should equal { expectedResult }, yet yielded { result }.");
        }

        [TestMethod]
        public void ItShouldDivideIntegersCorrectlyWithADecimalResult()
        {
            // arrange 
            var a = 11;
            var b = 2;
            var expectedResult = 5.5m;

            // act
            var result = _mathEngine.Divide(a, b);

            // assert
            Assert.AreEqual(expectedResult, result, $"Dividing integers { a } / { b } should equal { expectedResult }, yet yielded { result }.");
        }

        [TestMethod]
        public void ItShouldDivideIntegersCorrectlyWithAnIntegerResult()
        {
            // arrange 
            var a = 10;
            var b = 2;
            var expectedResult = 5;

            // act
            var result = _mathEngine.Divide(a, b);

            // assert
            Assert.AreEqual(expectedResult, result, $"Dividing integers { a } / { b } should equal { expectedResult }, yet yielded { result }.");
        }

        [TestMethod]
        public void ItShouldDivideDecimalsCorrectlyWithAnIntegerResult()
        {
            // arrange 
            var a = 12.5m;
            var b = 6.25m;
            var expectedResult = 2;

            // act
            var result = _mathEngine.Divide(a, b);

            // assert
            Assert.AreEqual(expectedResult, result, $"Dividing decimals { a } / { b } should equal { expectedResult }, yet yielded { result }.");
        }

        [TestMethod]
        public void ItShouldDivideDecimalsCorrectlyWithADecimalResult()
        {
            // arrange 
            var a = 12.75m;
            var b = 6.25m;
            var expectedResult = 2.04m;

            // act
            var result = _mathEngine.Divide(a, b);

            // assert
            Assert.AreEqual(expectedResult, result, $"Dividing decimals { a } / { b } should equal { expectedResult }, yet yielded { result }.");
        }
    }
}