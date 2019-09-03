using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTest3
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void Result_Should_Not_Be_Null()
        {
            //Arrange
            var FizzBuzz = new FizzBuzz.FizzBuzz();

            //Act
            var result = global::FizzBuzz.FizzBuzz.GetFizzBuzz(1);

            //Assert 
            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void Result_Should_Be_Fizz()
        {
            //Arrange
            var FizzBuzz = new FizzBuzz.FizzBuzz();

            //Act
            var result = global::FizzBuzz.FizzBuzz.GetFizzBuzz(3);

            //Assert 
            Assert.IsTrue(result == "Fizz");
        }

        [TestMethod]
        public void Result_Should_Be_Buzz()
        {
            //Arrange
            var FizzBuzz = new FizzBuzz.FizzBuzz();

            //Act
            var result = global::FizzBuzz.FizzBuzz.GetFizzBuzz(5);

            //Assert 
            Assert.IsTrue(result == "Buzz");
        }

        [TestMethod]
        public void Result_Should_Be_FizzBuzz()
        {
            //Arrange
            var FizzBuzz = new FizzBuzz.FizzBuzz();

            //Act
            var result = global::FizzBuzz.FizzBuzz.GetFizzBuzz(15);

            //Assert 
            Assert.IsTrue(result == "FizzBuzz");
        }

        [TestMethod]
        public void Result_Should_Not_Be_FizzBuzz()
        {
            //Arrange
            var FizzBuzz = new FizzBuzz.FizzBuzz();

            //Act
            var result = global::FizzBuzz.FizzBuzz.GetFizzBuzz(1);

            //Assert 
            Assert.IsFalse(result == "FizzBuzz");
        }
    }
}
