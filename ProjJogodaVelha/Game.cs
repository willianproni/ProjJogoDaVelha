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
                Escolha();
                Console.WriteLine($"\tRodada {Rodadas}, Vez do Jogador {Vez.Nome} ({Vez.Peca})\n");
                Console.Write("\tDigite a Linha:");
                int linha = int.Parse(Console.ReadLine());
                linha = linha - 1;
                Console.Write("\tDigite a Coluna:");
                int coluna = int.Parse(Console.ReadLine());
                coluna = coluna - 1;
                if (Jogo[linha, coluna] == 'X' || Jogo[linha, coluna] == 'O')
                {
                    do
                    {
                        Console.Clear();
                        Imprimir_Jogo();
                        Escolha();
                        Console.WriteLine($"Rodada {Rodadas}, Vez do Jogador {Vez.Nome}");
                        Console.WriteLine("Escolha uma Casa Vazia!!\n");
                        Console.WriteLine("Digite a Linha:");
                        linha = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a Coluna:");
                        coluna = int.Parse(Console.ReadLine());
                    } while (Jogo[linha, coluna] == 'X' || Jogo[linha, coluna] == 'O');

                }
                Rodadas++;
                Jogo[linha, coluna] = Vez.Peca;
                Imprimir_Jogo();
                VeririficaAll();
                //Situation();
                MudarVez();

            } while (Rodadas != 10);

        }

        public void CreatePlayers()
        {
            Console.Clear();
            Console.WriteLine("-_-_-_-_-_Nomeando Jogadores_-_-_-_-_-_-\n");
            Console.Write("Digite o Nome do JOGADOR 1(X): ");
            string nome1 = Console.ReadLine();
            char pecax = 'X';
            Jogador1 = new Jogador(nome1, pecax);
            Console.WriteLine();
            Console.Write("Digite o Nome do JOGADOR 2(O): ");
            string nome2 = Console.ReadLine();
            char pecao = 'O';
            Jogador2 = new Jogador(nome2, pecao);
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
        public void Situation()
        {

            if (Jogo[0, 0] == 'X' && Jogo[0, 1] == 'X' && Jogo[0, 2] == 'X' ||
                Jogo[0, 0] == 'O' && Jogo[0, 1] == 'O' && Jogo[0, 2] == 'O')
            {
                Console.Clear();
                Console.WriteLine($"-_-_-_-_Fim de jogo vencedor_-_-_-_-_-\n\t Ganhador {Vez.Nome}");
                Rodadas = 10;
                Console.ReadKey();
                Console.Clear();
            }
            else if (Jogo[1, 0] == 'X' && Jogo[1, 1] == 'X' && Jogo[1, 2] == 'X' ||
                     Jogo[1, 0] == 'O' && Jogo[1, 1] == 'O' && Jogo[1, 2] == 'O')
            {
                Console.Clear();
                Console.WriteLine($"-_-_-_-_Fim de jogo vencedor_-_-_-_-_-\n\t Ganhador {Vez.Nome}");
                Rodadas = 10;
                Console.ReadKey();
                Console.Clear();

            }
            else if (Jogo[2, 0] == 'X' && Jogo[2, 1] == 'X' && Jogo[2, 2] == 'X' ||
                     Jogo[2, 0] == 'O' && Jogo[2, 1] == 'O' && Jogo[2, 2] == 'O')
            {
                Console.Clear();
                Console.WriteLine($"-_-_-_-_Fim de jogo vencedor_-_-_-_-_-\n\t Ganhador {Vez.Nome}");
                Rodadas = 10;
                Console.ReadKey();
                Console.Clear();
            }
            else if (Jogo[0, 0] == 'X' && Jogo[1, 0] == 'X' && Jogo[2, 0] == 'X' ||
                     Jogo[0, 0] == 'O' && Jogo[1, 0] == 'O' && Jogo[2, 0] == 'O')
            {
                Console.Clear();
                Console.WriteLine($"-_-_-_-_Fim de jogo vencedor_-_-_-_-_-\n\t Ganhador {Vez.Nome}");
                Rodadas = 10;
                Console.ReadKey();
                Console.Clear();
            }
            else if (Jogo[0, 1] == 'X' && Jogo[1, 1] == 'X' && Jogo[2, 1] == 'X' ||
                     Jogo[1, 0] == 'O' && Jogo[1, 1] == 'O' && Jogo[2, 1] == 'O')
            {
                Console.Clear();
                Console.WriteLine($"-_-_-_-_Fim de jogo vencedor_-_-_-_-_-\n\t Ganhador {Vez.Nome}");
                Rodadas = 10;
                Console.ReadKey();
                Console.Clear();
            }
            else if (Jogo[2, 0] == 'X' && Jogo[2, 1] == 'X' && Jogo[2, 2] == 'X' ||
                     Jogo[2, 0] == 'O' && Jogo[2, 1] == 'O' && Jogo[2, 2] == 'O')
            {
                Console.Clear();
                Console.WriteLine($"-_-_-_-_Fim de jogo vencedor_-_-_-_-_-\n\t Ganhador {Vez.Nome}");
                Rodadas = 10;
                Console.ReadKey();
                Console.Clear();
            }
            else if (Jogo[0, 0] == 'X' && Jogo[1, 1] == 'X' && Jogo[2, 2] == 'X' ||
                     Jogo[0, 0] == 'O' && Jogo[1, 1] == 'O' && Jogo[2, 2] == 'O')
            {
                Console.Clear();
                Console.WriteLine($"-_-_-_-_Fim de jogo vencedor_-_-_-_-_-\n\t Ganhador {Vez.Nome}");
                Rodadas = 10;
                Console.ReadKey();
                Console.Clear();
            }
            else if (Jogo[0, 2] == 'X' && Jogo[1, 1] == 'X' && Jogo[2, 0] == 'X' ||
                     Jogo[0, 2] == 'O' && Jogo[1, 1] == 'O' && Jogo[2, 0] == 'O')
            {
                Console.Clear();
                Console.WriteLine($"-_-_-_-_Fim de jogo vencedor_-_-_-_-_-\n\t Ganhador {Vez.Nome}");
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
        }
        public void VerificaHorizontal()
        {
            int linha = 0;
            for (int i = linha; i < 3; i++)
            {
                for (int c = 0; c <= 0; c++)
                {

                    if (Jogo[linha, c] == 'X')
                    {
                        if (Jogo[linha, c + 1] == 'X')
                        {
                            if (Jogo[linha, c + 2] == 'X')
                            {
                                Console.Clear();
                                Console.WriteLine("-_-_-_-Resultado_-_-_-_-");
                                Console.WriteLine($"Vençedor {Vez.Nome}");
                                Rodadas = 10;
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                    }
                    if (Jogo[linha, c] == 'O')
                    {
                        if (Jogo[linha, c + 1] == 'O')
                        {
                            if (Jogo[linha, c + 2] == 'O')
                            {
                                Console.Clear();
                                Console.WriteLine("-_-_-_-Resultado_-_-_-_-");
                                Console.WriteLine($"\tVençedor {Vez.Nome}");
                                Rodadas = 10;
                                Console.ReadKey();
                                Console.Clear();

                            }
                        }
                    }
                }
                linha++;
            }
        }
        public void VerificaVertical()
        {
            int coluna = 0;
            for (int i = coluna; i < 3; i++)
            {
                for (int l = 0; l <= 0; l++)
                {
                    if (Jogo[l, coluna] == 'X')
                    {
                        if (Jogo[l + 1, coluna] == 'X')
                        {
                            if (Jogo[l + 2, coluna] == 'X')
                            {
                                Console.Clear();
                                Console.WriteLine("-_-_-_-Resultado_-_-_-_-");
                                Console.WriteLine($"Vençedor {Vez.Nome}");
                                Rodadas = 10;
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                    }
                    if (Jogo[l, coluna] == 'O')
                    {
                        if (Jogo[l + 1, coluna] == 'O')
                        {
                            if (Jogo[l + 2, coluna] == 'O')
                            {
                                Console.Clear();
                                Console.WriteLine("-_-_-_-Resultado_-_-_-_-");
                                Console.WriteLine($"Vençedor {Vez.Nome}");
                                Rodadas = 10;
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                    }
                }
                coluna++;
            }
        }
        public void VeririficaAll()
        {
            if (Jogo[0, 0] == 'X' && Jogo[1, 1] == 'X' && Jogo[2, 2] == 'X' ||
                Jogo[0, 0] == 'O' && Jogo[1, 1] == 'O' && Jogo[2, 2] == 'O')
            {
                Console.Clear();
                Console.WriteLine("-_-_-_-Resultado_-_-_-_-");
                Console.WriteLine($"Vençedor {Vez.Nome}");
                Rodadas = 10;
                Console.ReadKey();
                Console.Clear();
            }
            else if (Jogo[0, 2] == 'X' && Jogo[1, 1] == 'X' && Jogo[2, 0] == 'X' ||
                     Jogo[0, 2] == 'O' && Jogo[1, 1] == 'O' && Jogo[2, 0] == 'O')
            {
                Console.Clear();
                Console.WriteLine("-_-_-_-Resultado_-_-_-_-");
                Console.WriteLine($"Vençedor {Vez.Nome}");
                Rodadas = 10;
                Console.ReadKey();
                Console.Clear();
            }
            else if(Rodadas == 10)
            {
                Console.Clear();
                Console.WriteLine($"-_-_-_-_Fim de jogo vencedor_-_-_-_-_-\n\t Empate!!");
                Console.ReadKey();
                Console.Clear();
            }
            VerificaHorizontal();
            VerificaVertical();

        }
    }
}
