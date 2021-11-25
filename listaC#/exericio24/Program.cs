using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exericiico24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um caracter qualquer: ");
            char caractere = char.Parse(Console.ReadLine());
            Console.WriteLine("O valor retornado é: " + valor(caractere));
            Console.ReadKey();
        }
        static int valor(char caractere)
        {
            int codigo = Convert.ToInt32(caractere);
            {
                if ((codigo >= 65 && codigo <= 90 || (codigo >= 97 && codigo <= 122)))
                {
                    return 1;
                }
                return 0;
            }
        }
    }
}
