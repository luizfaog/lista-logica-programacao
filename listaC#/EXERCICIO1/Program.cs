using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;

            Console.WriteLine("Digite um número inteiro qualquer: ");
            n1 = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("O sucessor do numero digitado é: " + (n1 + 1));

            Console.WriteLine("antecessor do numero digitado é: " + (n1 - 1));

            Console.ReadLine();
        }
    }
}
