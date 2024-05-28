// See https://aka.ms/new-console-template for more information
using Calculadora.Services;

CalculadoraImpl calc = new();

int num1 = 10;
int num2 = 5;

Console.WriteLine($"x:{num1} + y:{num2} = {calc.Somar(10, 5)}");
