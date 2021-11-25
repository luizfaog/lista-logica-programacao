using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO10
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, raiz, quadrado;

            Console.WriteLine("Escreva um número inteiro qualquer: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            raiz = Math.Sqrt(n1);
            quadrado = n1 * n1;

            if (n1 >= 0)
            {
                Console.WriteLine("A raiz quadrada do número é: " + raiz);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("O quadrado do número é: " + quadrado);
                Console.ReadLine();
            }
        }
    }
}
