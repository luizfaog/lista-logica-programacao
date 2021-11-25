using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, média;

            Console.WriteLine("Digite um número real: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite outro número real: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite um último número real: ");
            n3 = Convert.ToDouble(Console.ReadLine());
            Console.ReadLine();

            média = (n1 + n2 + n3) / 3;

            Console.WriteLine("A média aritmética dos números reais informados é: " + média);
            Console.ReadLine();




        }
    }
}
