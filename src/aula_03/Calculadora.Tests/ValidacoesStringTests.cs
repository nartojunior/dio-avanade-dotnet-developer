using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;
using Xunit;

namespace Calculadora.Tests
{
    public class ValidacoesStringTests
    {
        private ValidacoesString _valicoesString;

        public ValidacoesStringTests()
        {
            _valicoesString = new();
        }

        [Fact]
        public void Contar3CarateresEmOlaRet3()
        {
            string ola = "ola";

            int result = _valicoesString.ContarCaracteres(ola);

            Assert.Equal(3, result);
        }
    }
}