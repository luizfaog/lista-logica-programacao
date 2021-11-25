using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            double latao, zinco, cobre;

            Console.WriteLine("Digite quantos kg de latão vai produzir: ");
            latao = Convert.ToDouble(Console.ReadLine());

            zinco = ((latao * 70) / 100);
            cobre = ((latao * 30) / 100);

            Console.WriteLine("As quantidades de zinco e cobre necessárias respectivamente são: " + "(" + zinco + ")" + "(" + cobre + ")");
            Console.ReadLine();


        }
    }
}
