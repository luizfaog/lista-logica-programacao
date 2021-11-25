using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, quadrado;


            for (i = 0; i <= 10; i++)
            {

                Console.WriteLine("Escreva um número: ");
                quadrado = Convert.ToInt32(Console.ReadLine());
                quadrado = quadrado * quadrado;
                Console.WriteLine("O quadrado do número é: " + quadrado);
                
            }
        }
    }
}
