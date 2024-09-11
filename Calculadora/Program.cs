using Calculadora.Services;

CalculadoraImp c = new CalculadoraImp();
int num1 = 5;
int num2 = 3;
int num3 = 0;

Console.WriteLine($"{num1} + {num2} = {c.Somar(num1, num2)}");
c.Dividir(num1, num3);