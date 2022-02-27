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
        public int Rodadas { get; set; }
        public char Jogador1 { get; set; }
        public char Jogador2 { get; set; }
        public char Vez { get; set; }

        public Game()
        {
            Jogo = null;
            Rodadas = 1;
            Jogador1 = 'X';
            Jogador2 = 'O';
            Vez = Jogador1;
        }

        public void Start()
        {
            Jogo = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } }; //As casas
            Rodadas = 1;
            Vez = Jogador1;
            Imprimir_Jogo(); //Imprimi o jogo na tela

            do
            {
                //Quantidade de jogadas

                int linha = 0;
                int coluna = 0;
                Escolha();
                do
                {
                    Console.WriteLine($"\tRodada {Rodadas}, Vez do {Vez}\n");
                    Console.Write("\tDigite a linha: ");
                    linha = int.Parse(Console.ReadLine());
                    Console.Write("\tDigite a Coluna: ");
                    coluna = int.Parse(Console.ReadLine());
                } while (Jogo[linha, coluna] == 'X' || Jogo[linha, coluna] == 'O');
                Rodadas++;
                Jogo[linha, coluna] = Vez;
                Imprimir_Jogo();
                Situation();
                MudarVez();

            } while (Rodadas != 10);

        }

        public void MudarVez()
        {
            Vez = Vez == Jogador1 ? Jogador2 : Jogador1;
        }

        public void Imprimir_Jogo()
        {
            Console.Clear();
            Console.WriteLine("-_-_-_-_Situação do Jogo_-_-_-_-_-\n");

            Console.WriteLine($"\t__{Jogo[0, 0]}__|__{Jogo[0, 1]}__|__{Jogo[0, 2]}__" +
                               $"\n\t__{Jogo[1, 0]}__|__{Jogo[1, 1]}__|__{Jogo[1, 2]}__" +
                               $"\n\t  {Jogo[2, 0]}  |  {Jogo[2, 1]}  |  {Jogo[2, 2]}  \n");

        }

        public void Escolha()
        {
            Console.WriteLine("1 = [0][0]" +
                              "\t\n2 = [0][1]" +
                              "\t\n3 = [0][2]" +
                              "\t\n4 = [1][0]" +
                              "\t\n5 = [1][1]" +
                              "\t\n6 = [1][2]" +
                              "\t\n7 = [2][0]" +
                              "\t\n8 = [2][1]" +
                              "\t\n9 = [2][2]\n");
        }

        public void VerificarPosition(int linha, int coluna)
        {
            do
            {
                Console.WriteLine("Digite a linha: ");
                linha = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a Coluna: ");
                coluna = int.Parse(Console.ReadLine());
            } while (Jogo[linha, coluna] == 'X' || Jogo[linha, coluna] == 'O');
        }

        public void Situation()
        {

            if (Jogo[0, 0] == 'X' && Jogo[0, 1] == 'X' && Jogo[0, 2] == 'X' ||
                Jogo[0, 0] == 'O' && Jogo[0, 1] == 'O' && Jogo[0, 2] == 'O')
            {
                Console.Clear();
                Console.WriteLine($"Fim de jogo vencedor {Vez}");
                Rodadas = 10;
                Console.ReadKey();
                Console.Clear();
            }
            else if (Jogo[1, 0] == 'X' && Jogo[1, 1] == 'X' && Jogo[1, 2] == 'X' ||
                     Jogo[1, 0] == 'O' && Jogo[1, 1] == 'O' && Jogo[1, 2] == 'O')
            {
                Console.Clear();
                Console.WriteLine($"Fim de jogo vencedor {Vez}");
                Rodadas = 10;
                Console.ReadKey();
                Console.Clear();

            }
            else if (Jogo[2, 0] == 'X' && Jogo[2, 1] == 'X' && Jogo[2, 2] == 'X' ||
                     Jogo[2, 0] == 'O' && Jogo[2, 1] == 'O' && Jogo[2, 2] == 'O')
            {
                Console.Clear();
                Console.WriteLine($"Fim de jogo vencedor {Vez}");
                Rodadas = 10;
                Console.ReadKey();
                Console.Clear();
            }
            else if (Jogo[0, 0] == 'X' && Jogo[1, 0] == 'X' && Jogo[2, 0] == 'X' ||
                     Jogo[0, 0] == 'O' && Jogo[1, 0] == 'O' && Jogo[2, 0] == 'O')
            {
                Console.Clear();
                Console.WriteLine($"Fim de jogo vencedor {Vez}");
                Rodadas = 10;
                Console.ReadKey();
                Console.Clear();
            }
            else if (Jogo[1, 0] == 'X' && Jogo[1, 1] == 'X' && Jogo[1, 2] == 'X' ||
                     Jogo[1, 0] == 'O' && Jogo[1, 1] == 'O' && Jogo[1, 2] == 'O')
            {
                Console.Clear();
                Console.WriteLine($"Fim de jogo vencedor {Vez}");
                Rodadas = 10;
                Console.ReadKey();
                Console.Clear();
            }
            else if (Jogo[2, 0] == 'X' && Jogo[2, 1] == 'X' && Jogo[2, 2] == 'X' ||
                     Jogo[2, 0] == 'O' && Jogo[2, 1] == 'O' && Jogo[2, 2] == 'O')
            {
                Console.Clear();
                Console.WriteLine($"Fim de jogo vencedor {Vez}");
                Rodadas = 10;
                Console.ReadKey();
                Console.Clear();
            }
            else if (Jogo[0, 0] == 'X' && Jogo[1, 1] == 'X' && Jogo[2, 2] == 'X' ||
                     Jogo[0, 0] == 'O' && Jogo[1, 1] == 'O' && Jogo[2, 2] == 'O')
            {
                Console.Clear();
                Console.WriteLine($"Fim de jogo vencedor {Vez}");
                Rodadas = 10;
                Console.ReadKey();
                Console.Clear();
            }
            else if (Jogo[0, 2] == 'X' && Jogo[1, 1] == 'X' && Jogo[2, 0] == 'X' ||
                     Jogo[0, 2] == 'O' && Jogo[1, 1] == 'O' && Jogo[2, 0] == 'O')
            {
                Console.Clear();
                Console.WriteLine($"Fim de jogo vencedor {Vez}");
                Rodadas = 10;
                Console.ReadKey();
                Console.Clear();
            }
            else if (Rodadas == 10)
            {
                Console.Clear();
                Console.WriteLine("Empate!!");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
