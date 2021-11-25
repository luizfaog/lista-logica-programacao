using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO20
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, quadrado;
            Console.WriteLine("Digite um número qualquer: ");
            n = Convert.ToInt32(Console.ReadLine());
            
            for (i=1; i<= n; i++)
            {
                quadrado = i * i;
                Console.WriteLine(quadrado);

            }
            Console.ReadLine();
        }
    }
}
