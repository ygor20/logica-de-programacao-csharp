using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica01
{
    internal class Program
    {
        static void Main(string[] args)
        {

           // Console.WriteLine("Olá mundo!");
            //Console.ReadLine();

            //variáveis
            char letra = 'a';
            string nome = "João";
            float temperatura = 36.5f;
            double salario = 12345.67;
            bool estachovendo = true;

            //alternando variáveis
             letra = 'b';
             nome = "Maria";
             temperatura = 37.0f;
             salario = 1500.00;
             estachovendo = false;

            // Constantes
            const char simbolo = '$';
            const string saudacao = "Bem-vindo ao c#!";
            const float pi = 3.14159f;
            const double altura = 1.75;
            const bool eVerdade = false ;     
            
            //char simbolo = "#";

            Console.WriteLine("Valores originais");
            Console.WriteLine($"Letra: {letra}");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Temperatura: {temperatura}");
            Console.WriteLine($"estachovendo: {estachovendo}");
            Console.WriteLine($"simbolo: {simbolo}");
            Console.WriteLine($"Pi:{pi}");
            Console.WriteLine($"Altura: {altura}");
            Console.WriteLine($"é verdade? {eVerdade}");
            Console.ReadLine();

        }
    }
}
