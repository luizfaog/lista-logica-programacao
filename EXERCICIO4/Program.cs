using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double p1, p2, p3, valor;

            Console.WriteLine("Digite a quantia total: ");
            valor = Convert.ToDouble(Console.ReadLine());

            p1 = ((valor * 30) / 100);
            p2 = ((valor * 38) / 100);
            p3 = ((valor * 32) / 100);

            Console.WriteLine("Os valores a serem recebidos pelas 3 partes respectivamente sao: " + p1 + "," + p2 + "," + p3);
            Console.ReadLine();
        }
    }
}
