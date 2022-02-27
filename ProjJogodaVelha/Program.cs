using System;

namespace ProjJogodaVelha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
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
                        Console.Clear();
                        Console.WriteLine("Fechado...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Digite uma opção válida!");
                        break;
                }
            } while (ops != 2);
        }
        public static void Menu()
        {
            Console.WriteLine("-------------Jogo da Velha--------------\n" +
                              "\n\t[1] - Start Game" +
                              "\n\t[2] - Close" +
                              "\n\n----------------------------------------");
            Console.Write("Opção: ");
        }
    }
}
