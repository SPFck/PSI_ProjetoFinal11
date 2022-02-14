using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoFinal
{
    public class Aluno_o
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }
        public string Estado { get; set; }

        public Aluno_o(string n, string e, int i, string ee)
        {
            this.Nome = n;
            this.Email = e;
            this.Idade = i;
            this.Estado = ee;
        }
    }
}
