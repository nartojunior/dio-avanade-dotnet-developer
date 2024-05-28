using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImpl
    {
        public int Somar(int x, int y)
        {
            return x + y;
        }

        public bool EhPar(int x)
        {
            return x % 2 == 0;
        }
    }
}