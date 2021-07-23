using System;

namespace Calculadora.Core
{
    public class CalculadoraCore
    {
        public CalculadoraCore(){}
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }
        public double FahrenheitParaCelsius(double f)
        {
            var resultado = (f - 32) * 5/9;
            return resultado;
        }
        public double CelsiusParaFahrenheit(double c)
        {
            var resultado = (c * 9/5) + 32;
            return resultado;
        }
    }
}
