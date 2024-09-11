using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests(){
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomarDoisNumerosERetornarOResultado()
    {
        // Arrange - Preparação do cenário
        int num1 = 5;
        int num2 = 3;

        // Act - Executar a ação
        int resultado = _calc.Somar(num1, num2);

        // Assert - Validação da ação
        Assert.Equal(8, resultado);
    }

    [Fact]
    public void DeveSubtrairDoisNumerosERetornarOResultado()
    {
        // Arrange - Preparação do cenário
        int num1 = 5;
        int num2 = 3;

        // Act - Executar a ação
        int resultado = _calc.Subtrair(num1, num2);

        // Assert - Validação da ação
        Assert.Equal(2, resultado);
    }

    [Fact]
    public void DeveMultiplicarDoisNumerosERetornarOResultado()
    {
        // Arrange - Preparação do cenário
        int num1 = 5;
        int num2 = 3;

        // Act - Executar a ação
        int resultado = _calc.Multiplicar(num1, num2);

        // Assert - Validação da ação
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveDividirDoisNumerosERetornarOResultado()
    {
        // Arrange - Preparação do cenário
        int num1 = 15;
        int num2 = 3;

        // Act - Executar a ação
        int resultado = _calc.Dividir(num1, num2);

        // Assert - Validação da ação
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void TestarHistorico()
    {
        // Arrange - Preparação do cenário

        // Act - Executar a ação
        _calc.Somar(1, 2);
        _calc.Somar(12, 2);
        _calc.Somar(21, 2);
        _calc.Somar(13, 2);

        var lista = _calc.Historico();
        // Assert - Validação da ação
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }

    [Theory]
    [InlineData(new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10})]
    public void DeveVerificarSeOsNumerosSaoParesOuImpares(int[] numeros)
    {
        Assert.All(numeros, num => {
            if(_calc.EhPar(num)){
                Assert.True(_calc.EhPar(num));
            }else{
                Assert.False(_calc.EhPar(num));
            }
        });
    }
}