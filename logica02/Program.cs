using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definindo as constantes
            const int valor1 = 10;
            const int valor2 = 5;

            //Soma
            int soma = valor1 + valor2;
            Console.WriteLine($"soma: {valor1} + {valor2} = {soma}");
            

            //subtração
            int subtracao = valor1 - valor2;
            Console.WriteLine($"subtração: {valor1} -{valor2} = {subtracao}");

            //Multiplicação
            int multiplicacao = valor1 * valor2;
            Console.WriteLine($"Multiplicação: {valor1} * {valor2} = {multiplicacao}");

            //Divisão
            int divisao = valor1 / valor2;
            Console.WriteLine($"Divisão: {valor1} / {valor2} = {divisao}");

            //Resto de divisão
            int resto = valor1 % valor2;
            Console.WriteLine($"Resto da divisão: {valor1} % {valor2} = {resto}");

            //Potenciação (usando math.pow para calcular a potencia)
            double potencia = Math.Pow (valor1, valor2);
            Console.WriteLine($"Potenciação: {valor1} elevado a {valor2} = {potencia}");

            //Ordem de grandeza

            //Exemplo 1: Sem parênteses
            int resultado1 = 3 + 5 * 2; // multiplicação tem prioridade
            Console.WriteLine($"Resultado 1 (sem parênteses): 3 + 5 * 2= {resultado1}");

            //Exemplo 1: com parênteses 
            int resultado2 = (3 + 5) * 2; // Parênteses alteram a ordem
            Console.WriteLine($"Resultado 2 (com parênteses); (3 + 5) * 2 = {resultado2}");

            //exemplo 2: Sem parênteses 
            int resultado3 = 8 / 4 + 3; // Divisão tem prioridade
            Console.WriteLine($"Resultado 3 (sem paênteses): 8/4 + 3 = {resultado3}");

            //exemplo 2: Com parênteses
            double resultado4 = 8.0 / (4 + 3); //Parênteses alteram a ordem
            Console.WriteLine($"Resultado 4 (com parênteses): 8/(4 +3) = {resultado4}");

            Console.ReadLine() ;

        }
    }
}
