using Xunit;
using System;
using Calculadora.Core;
using Shouldly;

namespace Calculadora.Core.Tests
{
    public class CalculadoraTest
    {
        [Fact]
        public void Soma_DoisNumeros_RetornaUmInt_Sucesso()
        {
            var calculadora = new CalculadoraCore();
            var resultado = calculadora.Somar(3, 2);

            Assert.Equal(5, resultado);
        }

        [Fact]
        public void Soma_DoisNumeros_RetornaUmInt_Falha()
        {
            var calculadora = new CalculadoraCore();
            var resultado = calculadora.Somar(2, 2);
            var condicao = resultado != 4;

            Assert.False(condicao);
        }

        [Fact]
        public void Subtrai_DoisNumeros_RetornaUmInt_Sucesso()
        {
            var calculadora = new CalculadoraCore();
            var resultado = calculadora.Subtrair(10, 2);

            Assert.Equal(8, resultado);
        }

        [Fact]
        public void Subtrai_DoisNumeros_RetornaUmInt_Falha()
        {
            var calculadora = new CalculadoraCore();
            var resultado = calculadora.Subtrair(10, 2);
            var condicao = resultado != 8;

            Assert.False(condicao);
        }

        [Fact]
        public void Multiplica_DoisNumeros_RetornaUmInt_Sucesso()
        {
            var calculadora = new CalculadoraCore();
            var resultado = calculadora.Multiplicar(5, 2);

            Assert.Equal(10, resultado);
        }
        [Fact]
        public void Multiplica_DoisNumeros_RetornaUmInt_Falha()
        {
            var calculadora = new CalculadoraCore();
            var resultado = calculadora.Multiplicar(5, 2);
            var condicao = resultado != 10;

            Assert.False(condicao);
        }

        [Fact]
        public void Divide_DoisNumeros_RetornaUmInt_Sucesso()
        {
            var calculadora = new CalculadoraCore();
            var resultado = calculadora.Dividir(10, 5);

            Assert.Equal(2, resultado);
        }

        [Fact]
        public void Divide_DoisNumeros_RetornaUmInt_Falha()
        {
            var calculadora = new CalculadoraCore();
            var resultado = calculadora.Dividir(10, 5);
            var condicao = resultado != 2;

            Assert.False(condicao);
        }

        [Theory(DisplayName = "Testando conversor fahrenheit para celsius")]
        [InlineData(75.2, 24)]
        [InlineData(95, 35)]
        [InlineData(59, 15)]
        public void Converte_FahrenheitParaCelsius_Theory(double f, double c)
        {
            var calculadora = new CalculadoraCore();
            var resultado = calculadora.FahrenheitParaCelsius(f);
               
            Assert.Equal(c, resultado);
        }
        [Theory(DisplayName = "Testando conversor celsius para fahrenheit")]
        [InlineData(24, 75.2)]
        [InlineData(35, 95)]
        [InlineData(15, 59)]
        public void Converte_CelsiusParaFahrenheit_Theory(double c, double f)
        {
            var calculadora = new CalculadoraCore();
            var resultado = calculadora.CelsiusParaFahrenheit(c);
               
            Assert.Equal(f, resultado);
        }
    }
}