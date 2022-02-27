using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjJogodaVelha
{
    internal class Jogador
    {
        public string Nome { get; set; }
        public char Peca { get; set; }

        public Jogador(string nome, char peca)
        {
            Nome = nome;
            Peca = peca;
        }
    }
}
