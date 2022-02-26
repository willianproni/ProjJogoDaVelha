using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjJogodaVelha
{
    internal class Game
    {
        public char[,] Jogo { get; set; }

        public char Jogador { get; set; }

        public Game(char[,] jogo)
        {
            Jogo = jogo;
            Jogador = 'X';

        }

        public void Start()
        {
            int cont = 1;
            int jogador = 1;
            Console.Clear();
            Console.WriteLine($"-_-_-RODADA {cont++}!!-_-_-\n");
            do
            {
                if (jogador > 2)
                {
                    jogador = 1;
                }
                Imprimir_Jogo();
                Console.WriteLine($"Vez do Jogador {jogador}:");
                jogador++;
                Console.WriteLine("\nEscolha a linha: ");
                int linha = int.Parse(Console.ReadLine());
                Console.WriteLine("Escolha a coluna: ");
                int coluna = int.Parse(Console.ReadLine());
                if (Jogo[linha, coluna] != 'X' || Jogo[linha, coluna] != 'O')
                {
                    for (int l = linha; l <= linha; l++)
                    {
                        for (int c = coluna; c <= coluna; c++)
                        {
                            Jogo[l, c] = Jogador;
                            Imprimir_Jogo();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Escolha outra casa!");
                }

            } while (cont != 9);
        }

        public void Imprimir_Jogo()
        {
            Console.Clear();
            Console.WriteLine("-_-_-_-_Situação do Jogo_-_-_-_-_-\n");

            int cont = 0;
            for (int l = 0; l < Jogo.GetLength(0); l++)
            {
                for (int c = 0; c < Jogo.GetLength(1); c++)
                {
                    Console.Write("\t" + Jogo[l, c] + "  ");
                    cont++;
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
            
        }

        public void VerificarPosition()
        {

        }
    }
}
