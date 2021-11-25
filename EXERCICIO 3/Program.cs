Susing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício3
{
    class Program
    {
        static void Main(string[] args)
        {
            Double c, f;

            Console.WriteLine("Digite a temperatura em celsius: ");
            c = Convert.ToDouble(Console.ReadLine());

            f = ((c * 9) / 5) + 32;

            Console.WriteLine("A temperatura convertida para fahrenheit é: " + f);

            Console.ReadLine();





        }
    }
}
