using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO99
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;

            Console.WriteLine("Escreva um numero inteiro qualquer: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            if (n1 > 0)
            {
                Console.WriteLine("POSITIVO");
                Console.ReadLine();
            }
            else if (n1 < 0)
            {
                Console.WriteLine("NEGATIVO");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("NULO");
                Console.ReadLine();
            }
        }
    }
}
