using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzKata
{
    [TestClass]
    public class FizzBuzzTest
    {
        private readonly FizzBuzz sut = new FizzBuzz();

        [TestMethod]
        public void ClassifyRegularNumbersAsIs()
        {
            Assert.AreEqual("1", sut.Classify(1));
            Assert.AreEqual("2", sut.Classify(2));
            Assert.AreEqual("4", sut.Classify(4));
        }

        [TestMethod]
        public void ClassifyDivisibleBy3AsFizz()
        {
            Assert.AreEqual("fizz", sut.Classify(3));
            Assert.AreEqual("fizz", sut.Classify(6));
        }

        [TestMethod]
        public void ClassifyDivisibleBy5AsBuzz()
        {
            Assert.AreEqual("buzz", sut.Classify(5));
            Assert.AreEqual("buzz", sut.Classify(10));
        }

        [TestMethod]
        public void ClassifyDivisibleByBoth3And5AsFizzBuzz()
        {
            Assert.AreEqual("fizzbuzz", sut.Classify(15));
            Assert.AreEqual("fizzbuzz", sut.Classify(30));
        }
    }
}
