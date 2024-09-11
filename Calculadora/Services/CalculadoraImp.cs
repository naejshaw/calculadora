using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        private List<string> listaHistorico;

        public Calculadora()
        {
            listaHistorico = new List<string>();
        }

        public int Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            listaHistorico.Insert(0, $"Soma: {num1} + {num2} = {resultado}");
            return resultado;
        }

        public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            listaHistorico.Insert(0, $"Subtração: {num1} - {num2} = {resultado}");
            return resultado;
        }

        public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            listaHistorico.Insert(0, $"Multiplicação: {num1} * {num2} = {resultado}");
            return resultado;
        }

        public int Dividir(int num1, int num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Não é possível dividir por 0");
            }
            int resultado = num1 / num2;
            listaHistorico.Insert(0, $"Divisão: {num1} / {num2} = {resultado}");
            return resultado;
        }

        public List<string> Historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }

        public bool EhPar(int num)
        {
            return num % 2 == 0;
        }
    }
}