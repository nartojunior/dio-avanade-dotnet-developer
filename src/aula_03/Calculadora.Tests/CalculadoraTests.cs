using Calculadora.Services;

namespace Calculadora.Tests;

public class CalculadoraTests
{
    private CalculadoraImpl _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImpl();
    }

    [Fact]
    public void Soma5Com10eRet15()
    {
        // Arrange
        int x = 5;
        int y = 10;        

        // Act
        int result = _calc.Somar(x, y);

        // Assert
        Assert.Equal(15, result);
    }

    [Fact]
    public void Soma10Com10eRet20()
    {
        // Arrange
        int x = 10;
        int y = 10;        

        // Act
        int result = _calc.Somar(x, y);

        // Assert
        Assert.Equal(20, result);
    }

     [Fact]
    public void Se4EhParRetTrue()
    {
        // Arrange
        int x = 10; 

        // Act
        bool result = _calc.EhPar(x);

        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]
    public void Numeros_2_4_6_8_10_SaoParesRetTrue(int x)
    {
        bool result = _calc.EhPar(x);
        Assert.True(result);
    }

    // Refatorando Teste Numeros Pares
    [Theory]
    [InlineData(new int[]{ 2, 4, 6, 8, 10})]
    public void Numeros_Refact_SaoParesRetTrue(int[] numeros)
    {
        Assert.All(numeros, num => _calc.EhPar(num));
    }
}