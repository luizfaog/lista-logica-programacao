using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO18
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, soma = 0;

            for (i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
                soma = soma + i;



            }
            
            Console.WriteLine("A soma de todos os numeros é: " + soma);
            Console.ReadLine();

        }
    }
}
