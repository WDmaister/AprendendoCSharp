using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicionais2\n");
            // João poderá entrar na festa?

            int idadej = 18;
            int quantidadeP = 2;

            bool acompanhado = quantidadeP >= 2;

            /* comando 'ou' é representado por "||"
             * comando 'e' é representado por "&&"
             */

            if (idadej >= 18 && acompanhado == true)
            {
                Console.WriteLine("João pode entrar.");
            }
            else
            {
                Console.WriteLine("João não pode entrar.");
            }

            Console.ReadLine();
        }
    }
}
