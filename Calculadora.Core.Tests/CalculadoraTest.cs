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

        [Theory(DisplayName = "Testando conversor fahrenheit para celsius")]
        [InlineData(75.2, 24)]
        [InlineData(95, 35)]
        [InlineData(59, 15)]
        public void Converte_FahrenheitParaCelsius_Sucesso(double f, double c)
        {
            var calculadora = new CalculadoraCore();
            var resultado = calculadora.FahrenheitParaCelsius(f);
               
            // Console.WriteLine($"\nA temperatura {f}ºF foi convertida para {resultado}ºC");
            Assert.Equal(c, resultado);
        }
        [Theory]
        [InlineData(24, 75.2)]
        [InlineData(35, 95)]
        [InlineData(15, 59)]
        public void Converte_CelsiusParaFahrenheit_Sucesso(double c, double f)
        {
            var calculadora = new CalculadoraCore();
            var resultado = calculadora.CelsiusParaFahrenheit(c);
               
            // Console.WriteLine($"\nA temperatura {c}ºC foi convertida para {resultado}ºF");
            Assert.Equal(f, resultado);
        }
    }
}