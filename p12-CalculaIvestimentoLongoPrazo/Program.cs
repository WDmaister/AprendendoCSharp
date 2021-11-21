using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p12_CalculaIvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 12\n");

            double fatorRendimento = 1.0036;
            double valorInvestido = 400;

            for (int ContadorAno = 1; ContadorAno <= 5; ContadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                }
                fatorRendimento += 0.0010;
            }

            Console.WriteLine("Tempo de Investimento foi de ");
            Console.WriteLine("Ao termino do investimento, você terá R$" + valorInvestido);
            Console.ReadLine();
        }
    }
}
