using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOGO_DA_VELHA
{
    class Program
    {
        static void Main(string[] args)
        {
            string jogador1, jogador2;
            string[] posicoes = Enumerable.Repeat("-", 9).ToArray();
            int jogadorDaVez = 1;
            bool alguemGanhou = false;
            int posicaoEscolhida = 0;
            string jogadorGanhador = "0";
            Console.WriteLine("Jogador 1, digite seu nome: ");
            jogador1 = Console.ReadLine();
            Console.WriteLine("Jogador 2, digite seu nome: ");
            jogador2 = Console.ReadLine();

            while (!alguemGanhou)
            {
                Console.WriteLine(" | | ");
                Console.WriteLine($"{posicoes[0]}|{posicoes[1]}|{posicoes[2]}");
                Console.WriteLine(" | | ");
                Console.WriteLine($"{posicoes[3]}|{posicoes[4]}|{posicoes[5]}");
                Console.WriteLine(" | | ");
                Console.WriteLine($"{posicoes[6]}|{posicoes[7]}|{posicoes[8]}");
                Console.WriteLine(" | | ");
                Console.WriteLine("");
                Console.WriteLine("Jogador {0}, escolha uma posição de 0 a 8 com base nas posições do jogo da velha: ", jogadorDaVez);

                posicaoEscolhida = int.Parse(Console.ReadLine());

                if (posicaoEscolhida >= 0 && posicaoEscolhida <= 8 && posicoes[posicaoEscolhida] == "-")
                {
                    if (jogadorDaVez == 1)
                    {
                        posicoes[posicaoEscolhida] = "X";
                        jogadorDaVez = 2;
                    }
                    else
                    {
                        posicoes[posicaoEscolhida] = "O";
                        jogadorDaVez = 1;
                    }
                }
                else if (posicaoEscolhida<0 || posicaoEscolhida > 8)
                {
                    Console.WriteLine("Posição inexistente, escolha outra");
                }
                else
                {
                    Console.WriteLine("Posição já escolhida, escolha outra.");
                }
                
                if ((posicoes[0] == "X") && (posicoes[1] == "X") && (posicoes[2] == "X"))
                {
                    alguemGanhou = true;
                    jogadorGanhador = jogador1;
                }
                else if ((posicoes[3] == "X") && (posicoes[4] == "X") && (posicoes[5] == "X"))
                {
                    alguemGanhou = true;
                    jogadorGanhador = jogador1;
                }
                else if ((posicoes[6] == "X") && (posicoes[7] == "X") && (posicoes[8] == "X"))
                {
                    alguemGanhou = true;
                    jogadorGanhador = jogador1;
                }
                else if ((posicoes[0] == "X") && (posicoes[3] == "X") && (posicoes[6] == "X"))
                {
                    alguemGanhou = true;
                    jogadorGanhador = jogador1;
                }
                else if ((posicoes[1] == "X") && (posicoes[4] == "X") && (posicoes[7] == "X"))
                {
                    alguemGanhou = true;
                    jogadorGanhador = jogador1;
                }
                else if ((posicoes[2] == "X") && (posicoes[5] == "X") && (posicoes[8] == "X"))
                {
                    alguemGanhou = true;
                    jogadorGanhador = jogador1;
                }
                else if ((posicoes[0] == "X") && (posicoes[4] == "X") && (posicoes[8] == "X"))
                {
                    alguemGanhou = true;
                    jogadorGanhador = jogador1;
                }
                else if ((posicoes[2] == "X") && (posicoes[4] == "X") && (posicoes[6] == "X"))
                {
                    alguemGanhou = true;
                    jogadorGanhador = jogador1;
                }

                if ((posicoes[0] == "O") && (posicoes[1] == "O") && (posicoes[2] == "O"))
                {
                    alguemGanhou = true;
                    jogadorGanhador = jogador2;
                }
                else if ((posicoes[3] == "O") && (posicoes[4] == "O") && (posicoes[5] == "O"))
                {
                    alguemGanhou = true;
                    jogadorGanhador = jogador2;
                }
                else if ((posicoes[6] == "O") && (posicoes[7] == "O") && (posicoes[8] == "O"))
                {
                    alguemGanhou = true;
                    jogadorGanhador = jogador2;
                }
                else if ((posicoes[0] == "O") && (posicoes[3] == "O") && (posicoes[6] == "O"))
                {
                    alguemGanhou = true;
                    jogadorGanhador = jogador2;
                }
                else if ((posicoes[1] == "O") && (posicoes[4] == "O") && (posicoes[7] == "O"))
                {
                    alguemGanhou = true;
                    jogadorGanhador = jogador2;
                }
                else if ((posicoes[2] == "O") && (posicoes[5] == "O") && (posicoes[8] == "O"))
                {
                    alguemGanhou = true;
                    jogadorGanhador = jogador2;
                }
                else if ((posicoes[0] == "O") && (posicoes[4] == "O") && (posicoes[8] == "O"))
                {
                    alguemGanhou = true;
                    jogadorGanhador = jogador2;
                }
                else if ((posicoes[2] == "O") && (posicoes[4] == "O") && (posicoes[6] == "O"))
                {
                    alguemGanhou = true;
                    jogadorGanhador = jogador2;
                }
                bool temPosicoesRestantes = false;
                for (int i = 0; i < 9; i++) { 
                    if (posicoes[i] == "-")
                    {
                        temPosicoesRestantes = true;
                    }
                }
                if (!temPosicoesRestantes && !alguemGanhou)
                {

                    Console.WriteLine("O jogo empatou!");
                    break;
                }    
                
                




            }
            Console.WriteLine(" | | ");
            Console.WriteLine($"{posicoes[0]}|{posicoes[1]}|{posicoes[2]}");
            Console.WriteLine(" | | ");
            Console.WriteLine($"{posicoes[3]}|{posicoes[4]}|{posicoes[5]}");
            Console.WriteLine(" | | ");
            Console.WriteLine($"{posicoes[6]}|{posicoes[7]}|{posicoes[8]}");
            Console.WriteLine(" | | ");
            if (jogadorGanhador != "0")
            {
                Console.WriteLine("Jogador {0} ganhou!", jogadorGanhador);
            }
                Console.ReadLine();
            
        }
    }
}
