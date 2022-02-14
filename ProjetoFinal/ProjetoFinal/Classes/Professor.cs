using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoFinal
{
    public class Professor
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Disciplina { get; set; }

        public Professor(string n, string e, string d)
        {
            this.Nome = n;
            this.Email = e;
            this.Disciplina = d;
        }
    }
}
