using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Escreva um número inteiro qualquer: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            if (n1 == 5)
            {
                Console.WriteLine("Esse número é igual a 5");
                Console.ReadLine();
            }
            else if (n1 == 200)
            {
                Console.WriteLine("Esse número é igual a 200");
                Console.ReadLine();
            }
            else if (n1 == 400)
            {
                Console.WriteLine("Esse número é igual a 400");
                Console.ReadLine();
            }
            else if (500 <= n1 && n1 <= 1000)
            {
                Console.WriteLine("Esse número se encontra no intervallo entre 500 e 1000");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Esse número não atende a nenhuma das especificações");
                Console.ReadLine();
            }
        }
    }
}
