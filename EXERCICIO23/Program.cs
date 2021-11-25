using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO23
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Escreva o nome que deve constar no cabeçalho");
            string nome = Console.ReadLine();

            cabecalho(nome);

            Console.ReadKey();
        }
        static void cabecalho(string nome)
        {
            
            Console.WriteLine("===========================================");
            Console.WriteLine("UFMG – Universidade Federal de Minas Gerais");
            Console.WriteLine("ICEx – Instituto de Ciências Exatas ");
            Console.WriteLine("Disciplina de Programação de Computadores");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("===========================================");

        }

      
    }
}
