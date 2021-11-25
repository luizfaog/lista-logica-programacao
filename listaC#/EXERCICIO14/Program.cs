using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO14
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, quadrado1, quadrado2, raiz1, raiz2;

            Console.WriteLine("Escreva um numero real qualquer");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escreva outro numero real qualquer");
            n2 = Convert.ToDouble(Console.ReadLine());
            
            if (n1> n2)
            {
                quadrado1 = (n2 * n2);
                raiz1 = Math.Sqrt(n1);

                Console.WriteLine("O quadrado do menor número é: " + quadrado1 + "A raiz quadrada do maior número é: " + raiz1);
                Console.ReadLine();
            }
            else if (n2 > n1)
            {
                quadrado2 = (n1 * n1);
                raiz2 = Math.Sqrt(n2);


                Console.WriteLine("O quadrado do menor número é: "+ quadrado2 + " E a raiz quadrada do maior número é: "+ raiz2);
                Console.ReadLine();
            }



        }
    }
}
