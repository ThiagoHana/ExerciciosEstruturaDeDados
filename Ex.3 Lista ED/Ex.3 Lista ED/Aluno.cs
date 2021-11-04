using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._3_Lista_ED
{
    class Aluno
    {
        public int RA { get; set; }
        public string Nome { get; set; }

        public Aluno()
        {

        }

        public Aluno(int ra, string nome)
        {
            RA = ra;
            Nome = nome;
        }
    }
}
