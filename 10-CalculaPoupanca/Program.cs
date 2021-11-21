using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exexutando projeto 10 - Calcula pupança\n");

            double ValorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                // 0.36% = 0.0036
                ValorInvestido = ValorInvestido + ValorInvestido * 0.0036;
                if (contadorMes == 1)
                {
                    Console.WriteLine("Após " + contadorMes + " mês , você terá R$" + ValorInvestido);
                }
                else
                {
                    Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + ValorInvestido);
                }
                contadorMes++;

                /*
                Maneiras de fazer um contador:

                contadorMes = contadorMes + 1;
                contadorMes += 1;
                contadorMes++;
                */
            }
            Console.ReadLine();
        }
    }
}
