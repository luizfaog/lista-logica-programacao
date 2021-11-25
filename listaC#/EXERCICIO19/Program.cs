using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO19
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, soma=0, quadrado;

            for (i=1; i<=100; i++)
            {
                Console.WriteLine(i);
                quadrado = i * i;
                
                soma = quadrado + soma;
                
            }
            Console.WriteLine("A soma do quadrado dos números é: "+ soma);
            Console.ReadLine();

        }
    }
}
