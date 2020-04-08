using Bogus;
using System;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace PerfectNumberProject.Domain.Tests
{
    [ExcludeFromCodeCoverage]
    public class PerfectNumberTest
    {
        [Fact]
        public void Number_VerifyNumberIsPerfect()
        {
            //Arrange
            var number = new Faker().Random.Int(1, 10000);
            //Act
            var perfectNumber = new PerfectNumberClass(number);
            //Assert
            Assert.Equal(number, perfectNumber.Number);
        }

        [Fact]
        public void Number_PerfectNumber_VerificarExecaoComNumeroNegativos()
        {
            //Arrange
            var number = new Faker().Random.Int(-1000, 0);
            var numberInt = new PerfectNumberClass(number);
            //Act
            var exception = Assert.Throws<Exception>(() => numberInt.IsPerfectNumber(number));
            //Assert
            Assert.Equal("This value a invalid number to this service", exception.Message);
        }

        [Fact]
        public void Number_PerfectNumber_VerificarExecaoComNumeroPositivos()
        {
            //Arrange
            var number = new Faker().Random.Int(10001, 150000);
            var numberInt = new PerfectNumberClass(number);
            //Act
            var exception = Assert.Throws<Exception>(() => numberInt.IsPerfectNumber(number));
            //Assert
            Assert.Equal("This value a invalid number to this service", exception.Message);
        }
    }
}
