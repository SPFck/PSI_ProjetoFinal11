using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoFinal
{
    public class Disciplina_o
    {
        public string Nome { get; set; }
        public int Modulos { get; set; }

        public Disciplina_o(string n, int m)
        {
            this.Nome = n;
            this.Modulos = m;
        }
    }
}
