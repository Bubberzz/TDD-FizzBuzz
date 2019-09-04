using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTest3
{
    [TestClass]
    public class FizzBuzzTests
    {
        [DataTestMethod]
        [DataRow(1)]
        [DataRow(23)]
        [DataRow(6346)]
        [DataRow(834435)]
        public void Result_Should_Not_Be_Null(int number)
        {
            //Arrange
            var FizzBuzz = new FizzBuzz.FizzBuzz();

            //Act
            var result = FizzBuzz.GetFizzBuzz(number);

            //Assert 
            Assert.IsTrue(result != null);
        }

        [DataTestMethod]
        [DataRow(3)]
        [DataRow(9)]
        [DataRow(147)]
        [DataRow(288)]
        [DataRow(12324)]
        public void Result_Should_Be_Fizz(int number)
        {
            //Arrange
            var FizzBuzz = new FizzBuzz.FizzBuzz();

            //Act
            var result = FizzBuzz.GetFizzBuzz(number);

            //Assert 
            Assert.IsTrue(result == "Fizz");
        }

        [DataTestMethod]
        [DataRow(5)]
        [DataRow(65)]
        [DataRow(875)]
        [DataRow(2345)]
        public void Result_Should_Be_Buzz(int number)
        {
            //Arrange
            var FizzBuzz = new FizzBuzz.FizzBuzz();

            //Act
            var result = FizzBuzz.GetFizzBuzz(number);

            //Assert 
            Assert.IsTrue(result == "Buzz");
        }

        [DataTestMethod]
        [DataRow(30)]
        [DataRow(345)]
        [DataRow(765)]
        [DataRow(245982945)]
        public void Result_Should_Be_FizzBuzz(int number)
        {
            //Arrange
            var FizzBuzz = new FizzBuzz.FizzBuzz();

            //Act
            var result = FizzBuzz.GetFizzBuzz(number);

            //Assert 
            Assert.IsTrue(result == "FizzBuzz");
        }

        [DataTestMethod]
        [DataRow(1)]
        [DataRow(66)]
        [DataRow(863)]
        [DataRow(45647354)]
        public void Result_Should_Not_Be_FizzBuzz(int number)
        {
            //Arrange
            var FizzBuzz = new FizzBuzz.FizzBuzz();

            //Act
            var result = FizzBuzz.GetFizzBuzz(number);

            //Assert 
            Assert.IsFalse(result == "FizzBuzz");
        }
    }
}
