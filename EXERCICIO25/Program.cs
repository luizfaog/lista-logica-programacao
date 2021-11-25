using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO24
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("Digite um número inteiro qualquer: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número inteiro qualquer: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("O menor valor é: " + Calculovalor(num1, num2));
            Console.ReadKey();
        }
        
        static int Calculovalor(int num1, int num2)
        {
            int menorvalor = 0;
             
            if (num1 > num2)
            {
                menorvalor = num2;
            }
            else 
            {
                menorvalor = num1;
            }

            return menorvalor;

        }
    }
}
