using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variaveis\n");

            int idade;
            idade = 11;

            idade = idade+idade-1;
            Console.WriteLine("vc tem " + idade + " anos de idade");

            Console.WriteLine("\nPara fechar o progama, pressione a tecla Enter");
            Console.ReadLine();

        }
    }
}
