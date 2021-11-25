using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO21
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            Console.WriteLine("Escreva um número qualquer: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i=1; i<=n; i++)
            {
                Console.Write(i + ",");
                Console.Write(i + 3 + ",");
                Console.Write(i + 3 + ",");
            }
            Console.ReadKey();
        }
    }
}
