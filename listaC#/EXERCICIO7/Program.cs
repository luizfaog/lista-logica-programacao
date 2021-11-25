using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, soma;

            Console.WriteLine("Digite o primeiro numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            soma = (n1 + n2);

            if (soma > 10)
            {
                Console.WriteLine("O resultado da sua soma é: " + soma);
                Console.ReadLine();
            }
            else if (soma <= 10)
            {
                Console.WriteLine("O valor da sua soma não é suficiente para ser impresso");
                Console.ReadLine();
            }

        }
    }
}
