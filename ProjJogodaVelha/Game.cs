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
        public Jogador Jogador1 { get; set; }
        public Jogador Jogador2 { get; set; }
        public Jogador Vez { get; set; }

        public Game()
        {
            Jogo = null;
            Rodadas = 1;
        }

        public void Start()
        {
            Jogo = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
            Rodadas = 1;
            CreatePlayers();
            Vez = Jogador1;
            Imprimir_Jogo();
            do
            {
                int linha, coluna;
                Escolha();
                Console.WriteLine($"\tRodada {Rodadas}, Vez do Jogador {Vez.Nome} ({Vez.Peca})\n");
                do
                {
                    Console.Write("\tDigite a Linha:");
                    linha = int.Parse(Console.ReadLine());
                } while (linha < 1 || linha > 3);
                linha = linha - 1;
                do
                {
                    Console.Write("\tDigite a Coluna:");
                    coluna = int.Parse(Console.ReadLine());
                } while (coluna < 1 || coluna > 3);
                coluna = coluna - 1;
                if (VerificarSePosicaoEstaDisponivel(linha, coluna))
                {
                    do
                    {
                        Console.Clear();
                        Imprimir_Jogo();
                        Escolha();
                        Console.WriteLine($"\tRodada {Rodadas}, Vez do Jogador {Vez.Nome}");
                        Console.WriteLine("\tEssa casa não está Vazia | Escolha uma Casa Vazia!!\n");
                        do
                        {
                            Console.Write("\tDigite a Linha:");
                            linha = int.Parse(Console.ReadLine());
                        } while (linha < 0 || linha > 3);
                        linha = linha - 1;
                        do
                        {
                            Console.Write("\tDigite a Coluna:");
                            coluna = int.Parse(Console.ReadLine());
                        } while (coluna < 0 || coluna > 3);
                        coluna = coluna - 1;
                    } while (VerificarSePosicaoEstaDisponivel(linha, coluna));
                }
                Rodadas++;
                Jogo[linha, coluna] = Vez.Peca;
                Imprimir_Jogo();
                if (Rodadas > 4)
                {
                    VeririficaAll();
                }
                //Situation();
                MudarVez();

            } while (Rodadas != 10);
        }

        public bool VerificarSePosicaoEstaDisponivel(int linha, int coluna)
        {
            if (Jogo[linha, coluna] == 'X' || Jogo[linha, coluna] == 'O')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CreatePlayers()
        {
            Console.Clear();
            Console.WriteLine("-_-_-_-_-_Nomeando Jogadores_-_-_-_-_-_-\n");
            Console.Write("Digite o Nome do JOGADOR 1(X): ");
            string nome1 = Console.ReadLine();
            char peca1 = 'X';
            Jogador1 = new Jogador(nome1, peca1);
            Console.WriteLine();
            Console.Write("Digite o Nome do JOGADOR 2(O): ");
            string nome2 = Console.ReadLine();
            char peca2 = 'O';
            Jogador2 = new Jogador(nome2, peca2);
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
            Console.WriteLine("\t\n     L  C" +
                              "\n1 = [1][1]" +
                              "\n2 = [1][2]" +
                              "\n3 = [1][3]" +
                              "\n4 = [2][1]" +
                              "\n5 = [2][2]" +
                              "\n6 = [2][3]" +
                              "\n7 = [3][1]" +
                              "\n8 = [3][2]" +
                              "\n9 = [3][3]\n");
        }

        public void VerificaHorizontal()
        {
            int linha = 0;
            int coluna = 0;
            for (int i = linha; i < 3; i++)
            {
                if (Jogo[linha, coluna].CompareTo(Jogo[linha, coluna + 1]) == 0 &&
                    Jogo[linha, coluna + 1].CompareTo(Jogo[linha, coluna + 2]) == 0)
                {
                    if (Jogo[linha, coluna] == 'X')
                    {
                        Console.Clear();
                        Console.WriteLine("-_-_-_-Resultado_-_-_-_-");
                        Console.WriteLine($"\tVencedor {Vez.Nome}");
                        Rodadas = 10;
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("-_-_-_-Resultado_-_-_-_-");
                        Console.WriteLine($"\tVencedor {Vez.Nome}");
                        Rodadas = 10;
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                linha++;
            }
        }

        public void VerificaVertical()
        {
            int coluna = 0;
            int linha = 0;
            for (int i = coluna; i < 3; i++)
            {
                if (Jogo[linha, coluna].CompareTo(Jogo[linha + 1, coluna]) == 0 &&
                    Jogo[linha + 1, coluna].CompareTo(Jogo[linha + 2, coluna]) == 0)
                {
                    if (Jogo[linha, coluna] == 'X')
                    {
                        Console.Clear();
                        Console.WriteLine("-_-_-_-Resultado_-_-_-_-");
                        Console.WriteLine($"\tVencedor {Vez.Nome}");
                        Rodadas = 10;
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("-_-_-_-Resultado_-_-_-_-");
                        Console.WriteLine($"\tVencedor {Vez.Nome}");
                        Rodadas = 10;
                        Console.ReadKey();
                        Console.Clear();
                    }
                    coluna++;
                }
            }
        }

        public void VeririficaAll()
        {

            if (Jogo[0, 0] == 'X' && Jogo[1, 1] == 'X' && Jogo[2, 2] == 'X' ||
                Jogo[0, 0] == 'O' && Jogo[1, 1] == 'O' && Jogo[2, 2] == 'O')
            {
                Console.Clear();
                Console.WriteLine("-_-_-_-Resultado_-_-_-_-");
                Console.WriteLine($"Vencedor {Vez.Nome}");
                Rodadas = 10;
                Console.ReadKey();
                Console.Clear();
            }
            else if (Jogo[0, 2] == 'X' && Jogo[1, 1] == 'X' && Jogo[2, 0] == 'X' ||
                     Jogo[0, 2] == 'O' && Jogo[1, 1] == 'O' && Jogo[2, 0] == 'O')
            {
                Console.Clear();
                Console.WriteLine("-_-_-_-Resultado_-_-_-_-");
                Console.WriteLine($"Vencedor {Vez.Nome}");
                Rodadas = 10;
                Console.ReadKey();
                Console.Clear();
            }
            else if (Rodadas == 10)
            {
                Console.Clear();
                Console.WriteLine($"-_-_-_-_Fim de jogo vencedor_-_-_-_-_-\n\t Empate!!");
                Console.ReadKey();
                Console.Clear();
            }
            VerificaHorizontal();
            VerificaVertical();
        }

        public void Status(int retorno)
        {
            if (retorno == 1)
            {
                Console.WriteLine($"Vençedor = {Jogador1.Nome}");
            }
            else if (retorno == 2)
            {
                Console.WriteLine($"Vençedor = {Jogador2.Nome}");
            }
            else if (retorno == 0)
            {
                Console.WriteLine("Empate");
            }
        }
    }
}
