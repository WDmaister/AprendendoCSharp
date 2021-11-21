using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 Criando variáveis ponto flutuante\n");

            double salario;
            salario = 1600.00;
            double aumento;
            aumento = 25.8952345;

            Console.WriteLine("Salario atual: " + salario + "");

            salario = (salario/100)*aumento + salario;

            Console.WriteLine("Salario com " + aumento.ToString("N2") + "% de aumento: " + salario.ToString("N2") + "");

            Console.WriteLine("\nPara fechar o progama, pressione a tecla Enter");
            Console.ReadLine();
        }
    }
}
