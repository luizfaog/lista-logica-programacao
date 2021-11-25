using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;

            Console.WriteLine("Digite um número qualquer: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            if (n1 % 2 == 0)
            {
                Console.WriteLine("O número digitado é PAR");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("O numero digitado é ÍMPAR");
                Console.ReadLine();
            }





        }
    }
}
