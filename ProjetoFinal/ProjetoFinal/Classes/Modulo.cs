using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoFinal
{
    public class Modulo
    {
        public string Nome { get; set; }
        public string M { get; set; }
        public string Disciplina { get; set; }
        public int Nota { get; set; }

        public Modulo(string n, string mm, string d, int na)
        {
            this.Nome = n;
            this.M = mm;
            this.Disciplina = d;
            this.Nota = na;
        }
    }
}
