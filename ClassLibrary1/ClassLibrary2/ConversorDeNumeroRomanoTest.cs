using Bogus;
using ConversorNumeroRomano;
using System;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace ClassLibrary2
{
    [ExcludeFromCodeCoverage]
    public class ConversorDeNumeroRomanoTest
    {

        [Fact]
        public void ConversorNumeroRomanoRandomPositivos()
        {
            //Arrange
            var number = new Faker().Random.Int(0, 3990);
            //Act
            var conversorDeNumeroRomano = new ConversorDeNumeroRomano(number);
            //Assert
            Assert.Equal(number, conversorDeNumeroRomano.Number);

        }

    

        [Fact]
        public void ConversorNumeroRomanoVerificarExecaoComNumeroNegativos()
        {
            //Arrange
            var number = new Faker().Random.Int(-1000, 0);
            var numberInt = new ConversorDeNumeroRomano(number);
            //Act
            var exception = Assert.Throws<Exception>(() => numberInt.ToRoman(number));
            //Assert
            Assert.Equal("This value is to small / large to be converted.", exception.Message);
        }

        [Fact]
        public void ConversorNumeroRomanoVerificarExecaoComNumerosPositivos()
        {
            //Arrange
            var number = new Faker().Random.Int(4000, 5000);
            var numberInt = new ConversorDeNumeroRomano(number);
            //Act
            var exception = Assert.Throws<Exception>(() => numberInt.ToRoman(number));
            //Assert
            Assert.Equal("This value is to small / large to be converted.", exception.Message);
        }





    }
}
