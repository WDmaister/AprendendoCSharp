using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais\n");
            // João poderá entrar na festa?

            int idadej = 16;
            int quantidadeP = 3;

            if (idadej >= 18)
            {
                Console.WriteLine("João é maior de idade, pode entrar");
            }
            else
            {
                if (quantidadeP >= 2)
                {
                    Console.WriteLine("João é menor de idade, mas está acompanhando. Pode entrar");
                }
                else
                {
                    Console.WriteLine("João é menor de idade, não pode entrar");
                }

            }

            Console.ReadLine();
        }
    }
}
