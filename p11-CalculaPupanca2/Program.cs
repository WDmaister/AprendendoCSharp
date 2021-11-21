using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p11_CalculaPupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11\n");

            double valorInvestido = 1000;

            Console.WriteLine("Investimento inicial R$" + valorInvestido + "\n");

            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
/*
                 valorInvestido = valorInvestido + valorInvestido * 0.0036;
                 o valor investido para ser multiplicado por 1 dá a mesma coisa ou seja utilizando a espressão "valorInvestido = valorInvestido * 1.0036;" dá no mesmo.
*/
                valorInvestido = valorInvestido * 1.0036;
                if (contadorMes == 1)
                {
                    Console.WriteLine("Após " + contadorMes + " mês, você terá R$" + valorInvestido);
                }
                else
                {
                    Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorInvestido);
                }
            }


            Console.ReadLine();
        }
    }
}
