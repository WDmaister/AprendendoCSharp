using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Escopo\n");
            // João poderá entrar na festa?

            int idadej = 18;
            bool acompanhado = false;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "João está acompanhando.";
            }
            else
            {
                mensagemAdicional = "Porque João não está acompanhado.";
            }

            /* comando 'ou' é representado por "||"
             * comando 'e' é representado por "&&"
             */

            if (idadej >= 18 || acompanhado == true)
            {
                Console.WriteLine("João pode entrar.");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("João não pode entrar.");
                Console.WriteLine(mensagemAdicional);
            }

            Console.ReadLine();
        }
    }
}
