using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica11
{
    //Definição da classe pessoa
    internal class Pessoa
    {
        //Propriedades da classe
        public string nome { get; set; }
        public int idade { get; set; }
        //Método para exibir as informações da pessoa
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {nome} e eu tenho {idade} anos.");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            //Criando um objeto da classe pessoa
            Pessoa pessoal = new Pessoa();

            //Solicitando informações do usuário
            Console.Write("Digite seu nome:");
            pessoal.nome = Console.ReadLine();

            Console.Write("Digite sua idade:");
            pessoal.idade = int.Parse( Console.ReadLine() );

            //Chamando o método para apresentar as informações 
            pessoal.Apresentar();

            //Mantendo o console aberto
            Console.ReadLine();

        }
    }
}
