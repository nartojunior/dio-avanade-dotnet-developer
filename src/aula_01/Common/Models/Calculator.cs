using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Models
{
    public class Calculator
    {
        public void Sum(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtract(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multiply(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        public void Divide(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Pow(int x, int y)
        {
            Console.WriteLine($"{x} elevado a {y} = { (int) Math.Pow(x, y)}");
        }

        public void SquareRoot(int x)
        {
            Console.WriteLine($"Raiz quadrade de {x} = { Math.Round( Math.Sqrt(x), 4)}");
        }

        public void Sin(double angle)
        {
            double rad = angle * Math.PI / 180;
            
            Console.WriteLine($"Seno de {angle}º = { Math.Round(Math.Sin(rad), 4)}");
        }

        public void Cos(double angle)
        {
            double rad = angle * Math.PI / 180;
            
            Console.WriteLine($"Cosseno de {angle}º = { Math.Round(Math.Cos(rad), 4)}");
        }

        public void Tan(double angle)
        {
            double rad = angle * Math.PI / 180;
            
            Console.WriteLine($"Tangente de {angle}º = { Math.Round(Math.Tan(rad), 4)}");
        }

        public void TestCalculator()
        {
            Sum(10, 12);
            Subtract(10, 12);
            Multiply(5, 8);
            Divide(10, 2);
            Pow(2, 3);
            Sin(30d);
            Cos(30d);
            Tan(30d);
            SquareRoot(9);
        }
    }
}