using Bogus;
using System;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace FactorialNumberProject.Domain.Tests
{
    [ExcludeFromCodeCoverage]
    public class FactorialNumberTest
    {
        [Fact]
        public void Number_VerifyNumberIsFactorial()
        {
            //Arrange
            var number = new Faker().Random.Int(0, 30);
            //Act
            var factorialNumber = new FactorialNumber(number);
            //Assert
            Assert.Equal(number, factorialNumber.Number);
        }


        [Fact]
        public void Number_FactorialNumber_VerificarExecaoComNumeroNegativos()
        {
            //Arrange
            var number = new Faker().Random.Int(-50, 1);
            var numberInt = new FactorialNumber(number);
            //Act
            var exception = Assert.Throws<Exception>(() => numberInt.FactorialNumberCalc(number));
            //Assert
            Assert.Equal("This value is out of the range", exception.Message);
        }

        [Fact]
        public void Number_FactorialNumber_VerificarExecaoComNumeroPositivos()
        {
            //Arrange
            var number = new Faker().Random.Int(10001, 150000);
            var numberInt = new FactorialNumber(number);
            //Act
            var exception = Assert.Throws<Exception>(() => numberInt.FactorialNumberCalc(number));
            //Assert
            Assert.Equal("This value is out of the range", exception.Message);
        }
    }
}
