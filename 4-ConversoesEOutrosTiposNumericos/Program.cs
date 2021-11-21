using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4\n");


            double salario = 1200.75;

            // O int é um tipo de variavel que suporta valores até 32 bits
            int salariointeiro = (int)salario;
            Console.WriteLine(salariointeiro);


            // O long é um tipo de variavel que suporta valores de 64 bits
            long idade_universo = 1300000000000000000;
            Console.WriteLine(idade_universo);

            // O short é um tipo de varieavel que suporta valoreas de 16 bits
            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            // Quando for utilizar o float deve ser inserido a letra "f" apos o valor definido
            float altura = 1.80f;
            Console.WriteLine(altura);
            
            Console.ReadLine();
        }
    }
}
