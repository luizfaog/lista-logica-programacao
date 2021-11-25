using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;
            Console.WriteLine("Digite um número qualquer: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            if (n1 > 20)
            {
                Console.WriteLine("Parabéns seu número procede");
                Console.ReadLine();

            }
            else
            {
                Console.ReadLine();
            }

        }
    }
}
