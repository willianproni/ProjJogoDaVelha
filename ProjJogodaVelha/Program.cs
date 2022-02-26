using System;

namespace ProjJogodaVelha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } });
            int ops;

            do
            {
                Menu();
                ops = int.Parse(Console.ReadLine());
                switch (ops)
                {
                    
                    case 1:
                        game.Start();
                        break;
                    case 2:
                        game.Imprimir_Jogo();
                        break;
                    default:
                        Console.WriteLine("Digite uma opção válida!");
                        break;
                }
            } while (ops != 3);
        }
        public static void Menu()
        {
            Console.WriteLine("-------------Jogo da Velha--------------\n" +
                              "\n\t[1] - Start Game" +
                              "\n\t[2] - View Game" +
                              "\n\n----------------------------------------");
            Console.Write("Opção: ");
        }
    }
}
