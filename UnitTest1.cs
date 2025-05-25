using System.Security.Cryptography.X509Certificates;

namespace CalculatorApp
{
    public class Tests
    {
        public Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator(); 
        }


        [Test]
        public void TestAddition() => Assert.AreEqual(5, _calculator.Add(2, 3));

        [Test]
        public void TestSubtraction() => Assert.AreEqual(1, _calculator.Subtract(3, 2));

        [Test]
        public void TestMultiplication() => Assert.AreEqual(6, _calculator.Multiply(2, 3));

        [Test]
        public void TestDivision() => Assert.AreEqual(2, _calculator.Division(4, 2));
        [Test]
        public void TestMultiplicationWithZero()=> Assert.AreEqual(0,_calculator.Multiply(2, 0));

        [Test]
        public void TestDivideByZero() =>
            Assert.Throws<DivideByZeroException>(() => _calculator.Division(5, 0));

    }
}