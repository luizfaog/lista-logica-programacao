using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            Console.WriteLine("Escreva o primeiro número: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escreva o segundo número: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escreva o terceiro número: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2 && n1 > n3 && n2 > n3)
            {
                Console.WriteLine(n3 + "," + n2 + "," + n1);
                Console.ReadLine();
            }
            else if (n1 > n2 && n1 > n3 && n3 > n2)
            {
                Console.WriteLine(n2 + "," + n3 + "," + n1);
                Console.ReadLine();
            }
            else if (n2 > n1 && n2 > n3 && n1 > n3)
            {
                Console.WriteLine(n3 + "," + n1 + "," + n2);
                Console.ReadLine();
            }
            else if (n2 > n1 && n2 > n3 && n3 > n1)
            {
                Console.WriteLine(n1 + "," + n3 + "," + n2);
                Console.ReadLine();
            }
            else if (n3 > n1 && n3 > n2 && n1 > n2)
            {
                Console.WriteLine(n2 + "," + n1 + "," + n3);
                Console.ReadLine();
            }
            else if (n3 > n1 && n3 > n2 && n2 > n1)
            {
                Console.WriteLine(n1 + "," + n2 + "," + n3);
                Console.ReadLine();

            }
            }
    }
}
