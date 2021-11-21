using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos\n");

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Meus estudos " + 2021;
            string planoAprendizagem = 
@"- .NET
- Java
- SQL Server";
            Console.WriteLine(titulo);
            Console.WriteLine(planoAprendizagem);

            Console.WriteLine("\nPara fechar o progama, pressione a tecla Enter");
            Console.ReadLine();
        }
    }
}
