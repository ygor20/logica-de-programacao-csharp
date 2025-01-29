using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array
            string[] marcadecarro = { "Volvo", "BMW", "Ford", "BYD" };

            foreach (string carro in marcadecarro) //Mostrar toda a lista.
            {
                Console.WriteLine(carro);
            }

            for (int i = 0; i < marcadecarro.Length; i++) 
            {
                Console.WriteLine (marcadecarro[i]);
            }

            Console.WriteLine(string.Join(", ", marcadecarro));

            //Mostrar apenas o valor de um índice
            Console.WriteLine(marcadecarro[2]);

            //Exibindo comprimento do array
            Console.WriteLine(marcadecarro.Length);

            //Ordenação de forma crescente string de A - Z.
            Array.Sort(marcadecarro); // ordem alfabética
            foreach (string ordenado in  marcadecarro)

            {
                Console.WriteLine(ordenado);
            }
            //Ordenação de forma decrescente string de Z - A.
            Array.Reverse(marcadecarro);
            foreach (string ordenado in marcadecarro)

            {
                Console.WriteLine(ordenado);
            }

            //Análise de array
            int[] numeros = { 5, 1, 8, 9 };
            Console.WriteLine(numeros.Max()); //Maior valor
            Console.WriteLine(numeros.Min()); //Menor Valor
            Console.WriteLine(numeros.Sum()); //Soma todos os números

            Console.ReadLine();
        }
    }
}
